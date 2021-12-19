using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Label = System.Windows.Forms.Label;
using System.Windows.Forms.DataVisualization.Charting;

namespace sorting1
{
    public partial class Form1 : Form
    {
        double[] bubbleArray, insertionArray, shakerArray, quickArray, bogoArray;
        Thread bubbleSortThread, insertionSortThread, shakerSortThread, quickSortThread, bogoSortThread;
        List<Thread> threadList = new List<Thread>();
        List<Thread> threadListCurrent = new List<Thread>();
        bool isRunning = false;
        int runningCount = 0;
        int delay = 100;
        Action refresh, time;
        public Form1()
        {
            InitializeComponent();
        }
        #region data buttons
        private void getData()
        {
            List<double> values = new List<double>();
            for (int row = 0; row < dataGridView.Rows.Count - 1; ++row)
            {
                values.Add(Convert.ToDouble(dataGridView.Rows[row].Cells["Value"].Value));
            }
            bubbleArray = values.ToArray();
            shakerArray = values.ToArray();
            quickArray = values.ToArray();
            insertionArray = values.ToArray();
            bogoArray = values.ToArray();
        }
        private async void googleSheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();

                GoogleCredential credential;
                string[] Scopes = { SheetsService.Scope.Spreadsheets };
                string credFile = "credentials.json";
                string spreadsheetId = ""; //1jw2h-SQ6V7_K3A0v9pfpVMbRfDYdJb6RIi2MKc0plx8
                string range = "Лист1!A:A";
                SpreadsheetsResource.ValuesResource.GetRequest request;
                IList<IList<Object>> values = null;

                Form2 f2 = new Form2();
                var result = f2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    spreadsheetId = f2.spreadsheetId;
                }
                await Task.Run(() =>
                {
                    using (var fs = new FileStream(credFile, FileMode.Open, FileAccess.Read))
                    {
                        credential = GoogleCredential.FromStream(fs).CreateScoped(Scopes);
                    }
                    SheetsService service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = ""
                    });

                    try
                    {
                        request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                        values = request.Execute().Values;
                    }
                    catch (Google.GoogleApiException)
                    {
                        MessageBox.Show("Не введен ID документа!");
                    }

                    if (values != null && values.Count > 0)
                    {
                        foreach (var row in values)
                        {
                            Action addRow = () => dataGridView.Rows.Add(row[0].ToString());
                            Invoke(addRow);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Файл пуст или не найден!");
                    }
                });
                clearAfterImport();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            using (var ofd = new OpenFileDialog())
            {
                ofd.DefaultExt = "*.xls;*.xlsx";
                ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                ofd.Title = "Выберите файл для импорта";
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Open(ofd.FileName);
                    Excel.Worksheet sheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                    Excel.Range range = sheet.UsedRange;

                    var lastCell = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
                    int lastColumn = lastCell.Column;
                    int lastRow = lastCell.Row;
                    for (int index = 0; index < lastRow; ++index)
                    {
                        dataGridView.Rows.Add(sheet.Cells[index + 1, 1].Text.ToString());
                    }
                    workbook.Close(false, Type.Missing, Type.Missing);
                    excelApp.Quit();
                    excelApp.Quit();
                    GC.Collect();
                }
                else
                {
                    MessageBox.Show("Файл не выбран!");
                }
            }
            clearAfterImport();
        }
        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            Random random = new Random();
            for (int index = 0; index < random.Next(3, 15); ++index)
            {
                double value = random.Next(0, 500);
                dataGridView.Rows.Add(value);
            }
            clearAfterImport();
        }
        #endregion
        #region operate buttons
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var thread in threadList)
            {
                if (thread.ThreadState != System.Threading.ThreadState.Stopped && thread.ThreadState != System.Threading.ThreadState.Suspended)
                {
                    isRunning = true;
                }
            }
            try
            {
                if (isRunning == false)
                {
                    getData();
                    try
                    {
                        setDelay();
                        if (bubbleArray == null)
                        {
                            throw new Exception("Нужны данные для сортировки!");
                        }
                        if (bubbleArray.Length < 3)
                        {
                            throw new Exception("Нужно больше чисел для сортировки!");
                        }
                        if (!checkBoxAscending.Checked && !checkBoxDescending.Checked)
                        {
                            checkBoxAscending.Checked = true;
                        }
                        if (checkBoxAscending.Checked && checkBoxDescending.Checked)
                        {
                            throw new Exception("Выберите только один порядок сортировки!");
                        }
                        if (!checkBoxBubbleSort.Checked && !checkBoxInsertionSort.Checked && !checkBoxShakerSort.Checked && !checkBoxQuickSort.Checked && !checkBoxBogoSort.Checked)
                        {
                            throw new Exception("Выберите хотя бы один метод cортировки!");
                        }
                        if (checkBoxAscending.Checked)
                        {
                            if (checkBoxBubbleSort.Checked)
                            {
                                bubbleSortThread = new Thread(new ThreadStart(bubbleSort));
                                threadList.Add(bubbleSortThread);
                                bubbleSortThread.Start();
                            }
                            if (checkBoxInsertionSort.Checked)
                            {
                                insertionSortThread = new Thread(new ThreadStart(insertionSort));
                                threadList.Add(insertionSortThread);
                                insertionSortThread.Start();
                            }
                            if (checkBoxShakerSort.Checked)
                            {
                                shakerSortThread = new Thread(new ThreadStart(shakerSort));
                                threadList.Add(shakerSortThread);
                                shakerSortThread.Start();
                            }
                            if (checkBoxQuickSort.Checked)
                            {
                                quickSortThread = new Thread(new ThreadStart(quickSort));
                                threadList.Add(quickSortThread);
                                quickSortThread.Start();
                            }
                            if (checkBoxBogoSort.Checked)
                            {
                                bogoSortThread = new Thread(new ThreadStart(bogoSort));
                                threadList.Add(bogoSortThread);
                                bogoSortThread.Start();
                            }
                            isRunning = true;
                        }
                        if (checkBoxDescending.Checked)
                        {
                            if (checkBoxBubbleSort.Checked)
                            {
                                bubbleSortThread = new Thread(new ThreadStart(bubbleSortDesc));
                                threadList.Add(bubbleSortThread);
                                bubbleSortThread.Start();
                            }
                            if (checkBoxInsertionSort.Checked)
                            {
                                insertionSortThread = new Thread(new ThreadStart(insertionSortDesc));
                                threadList.Add(insertionSortThread);
                                insertionSortThread.Start();
                            }
                            if (checkBoxShakerSort.Checked)
                            {
                                shakerSortThread = new Thread(new ThreadStart(shakerSortDesc));
                                threadList.Add(shakerSortThread);
                                shakerSortThread.Start();
                            }
                            if (checkBoxQuickSort.Checked)
                            {
                                quickSortThread = new Thread(new ThreadStart(quickSortDesc));
                                threadList.Add(quickSortThread);
                                quickSortThread.Start();
                            }
                            if (checkBoxBogoSort.Checked)
                            {
                                bogoSortThread = new Thread(new ThreadStart(bogoSortDesc));
                                threadList.Add(bogoSortThread);
                                bogoSortThread.Start();
                            }
                            threadListCurrent = new List<Thread>(threadList);
                            isRunning = true;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Принимаются только числовые значения!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (threadListCurrent.Count == 0)
                    {
                        isRunning = false;
                        threadList.Clear();
                        threadListCurrent.Clear();
                        startToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        foreach (var thread in threadList)
                        {
                            if (thread.ThreadState != System.Threading.ThreadState.Stopped)
                            {
                                thread.Resume();
                            }
                            else
                            {
                                threadListCurrent.Remove(thread);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка! Нажмите Очистить!");
            }
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var thread in threadList)
            {
                if (thread.ThreadState != System.Threading.ThreadState.Stopped)
                {
                    thread.Suspend();
                }
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAfterImport();
            dataGridView.Rows.Clear();
        }
        private void clearAfterImport()
        {
            foreach (var thread in threadList)
            {
                if (thread.ThreadState == System.Threading.ThreadState.Suspended)
                {
                    thread.Resume();
                    thread.Abort();
                }
                else
                    thread.Abort();
            }
            threadList.Clear();
            delayTextBox.Text = "";
            delay = 100;
            isRunning = false;
            bubbleArray = new double[1];
            shakerArray = new double[1];
            quickArray = new double[1];
            insertionArray = new double[1];
            bogoArray = new double[1];
            clearItemGroup(bubbleSortGraph, bubbleSortLabel, checkBoxBubbleSort);
            clearItemGroup(insertionSortGraph, insertionSortLabel, checkBoxInsertionSort);
            clearItemGroup(shakerSortGraph, shakerSortLabel, checkBoxShakerSort);
            clearItemGroup(quickSortGraph, quickSortLabel, checkBoxQuickSort);
            clearItemGroup(bogoSortGraph, bogoSortLabel, checkBoxBogoSort);
            uncheck(checkBoxAscending);
            uncheck(checkBoxDescending);
        }
        private void clearItemGroup(Chart graph, Label label, CheckBox box)
        {
            clearGraph(graph);
            label.Text = "";
            uncheck(box);
        }
        private void clearGraph(Chart graph)
        {
            graph.Series[0].Points.Clear();
        }
        private void uncheck(CheckBox box)
        {
            box.CheckState = CheckState.Unchecked;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
        #region visual
        private void showProgress(double[] arr, Chart graph)
        {
            refresh = () => graph.Series[0].Points.DataBindY(arr);
            Invoke(refresh);
        }
        private void showTime(Label label, Stopwatch timer, double iter)
        {
            time = () => label.Text = (timer.ElapsedMilliseconds - iter * delay).ToString() + " мс";
            Invoke(time);
        }
        private void setDelay()
        {
            if (delayTextBox.Text != "")
            {
                delay = Convert.ToInt32(delayTextBox.Text);
            }
            else
            {
                delayTextBox.Text = delay.ToString();
            }
        }
        #endregion
        #region sorting asc
        private void swap(double[] arr, int x, int y)
        {
            double temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void bubbleSort()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            for (int firstIndex = 0; firstIndex < bubbleArray.Length; ++firstIndex)
            {
                for (int secondIndex = firstIndex + 1; secondIndex < bubbleArray.Length; ++secondIndex)
                {
                    if (bubbleArray[firstIndex] > bubbleArray[secondIndex])
                    {
                        swap(bubbleArray, firstIndex, secondIndex);
                        Thread.Sleep(delay);
                        ++iter;
                        showProgress(bubbleArray, bubbleSortGraph);
                    }
                }
            }
            timer.Stop();
            showTime(bubbleSortLabel, timer, iter);
        }
        private void insertionSort()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            for (int resIndex = 1; resIndex < insertionArray.Length; ++resIndex)
            {
                double key = insertionArray[resIndex];
                int rawIndex = resIndex - 1;
                while (rawIndex >= 0 && insertionArray[rawIndex] > key)
                {
                    insertionArray[rawIndex + 1] = insertionArray[rawIndex];
                    --rawIndex;
                }
                insertionArray[rawIndex + 1] = key;
                Thread.Sleep(delay);
                ++iter;
                showProgress(insertionArray, insertionSortGraph);
            }
            timer.Stop();
            showTime(insertionSortLabel, timer, iter);
        }
        private void shakerSort()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            for (int outerLoop = 0; outerLoop < shakerArray.Length / 2; ++outerLoop)
            {
                bool swapFlag = false;
                for (int innerLoop = outerLoop; innerLoop < shakerArray.Length - outerLoop - 1; ++innerLoop)
                {
                    if (shakerArray[innerLoop] > shakerArray[innerLoop + 1])
                    {
                        swap(shakerArray, innerLoop, innerLoop + 1);
                        swapFlag = true;
                        Thread.Sleep(delay);
                        ++iter;
                        showProgress(shakerArray, shakerSortGraph);
                    }
                }
                for (int innerLoop = shakerArray.Length - 2 - outerLoop; innerLoop > outerLoop; --innerLoop)
                {
                    if (shakerArray[innerLoop - 1] > shakerArray[innerLoop])
                    {
                        swap(shakerArray, innerLoop - 1, innerLoop);
                        swapFlag = true;
                        Thread.Sleep(delay);
                        ++iter;
                        showProgress(shakerArray, shakerSortGraph);
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            timer.Stop();
            showTime(shakerSortLabel, timer, iter);
        }
        private void quickSort()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            quickSort(0, quickArray.Length - 1);
            timer.Stop();
            showTime(quickSortLabel, timer, iter * (1 - 1 / delay));

            void quickSort(int minIndex, int maxIndex)
            {
                if (minIndex >= maxIndex)
                {
                    return;
                }
                var pivotIndex = choosePivot(quickArray, minIndex, maxIndex);
                quickSort(minIndex, (int)pivotIndex - 1);
                Thread.Sleep(delay);
                ++iter;
                showProgress(quickArray, quickSortGraph);
                quickSort((int)pivotIndex + 1, maxIndex);
                Thread.Sleep(delay);
                ++iter;
                showProgress(quickArray, quickSortGraph);
            }
        }
        double choosePivot(double[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var index = minIndex; index < maxIndex; ++index)
            {
                if (array[index] < array[maxIndex])
                {
                    ++pivot;
                    swap(array, pivot, index);
                }
            }
            ++pivot;
            swap(array, pivot, maxIndex);
            return pivot;
        }
        private void bogoSort()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            while (!isSorted())
            {
                randomPermutation();
                Thread.Sleep(delay);
                ++iter;
                showProgress(bogoArray, bogoSortGraph);
            }
            timer.Stop();
            showTime(bogoSortLabel, timer, iter);
        }
        bool isSorted()
        {
            for (int index = 0; index < bogoArray.Length - 1; ++index)
            {
                if (bogoArray[index] > bogoArray[index + 1])
                {
                    return false;
                }
            }
            return true;
        }
        void randomPermutation()
        {
            Random random = new Random();
            for (int index = bogoArray.Length - 1; index > 0; --index)
            {
                int newIndex = random.Next(bogoArray.Length - 1);
                swap(bogoArray, newIndex, index);
            }
        }
        #endregion
        #region sorting desc
        private void bubbleSortDesc()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            for (int firstIndex = 0; firstIndex < bubbleArray.Length; ++firstIndex)
            {
                for (int secondIndex = firstIndex + 1; secondIndex < bubbleArray.Length; ++secondIndex)
                {
                    if (bubbleArray[firstIndex] < bubbleArray[secondIndex])
                    {
                        swap(bubbleArray, firstIndex, secondIndex);
                        Thread.Sleep(delay);
                        ++iter;
                        showProgress(bubbleArray, bubbleSortGraph);
                    }
                }
            }
            timer.Stop();
            showTime(bubbleSortLabel, timer, iter);
        }
        private void insertionSortDesc()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            for (int resIndex = 1; resIndex < insertionArray.Length; ++resIndex)
            {
                double key = insertionArray[resIndex];
                int rawIndex = resIndex - 1;
                while (rawIndex >= 0 && insertionArray[rawIndex] < key)
                {
                    insertionArray[rawIndex + 1] = insertionArray[rawIndex];
                    --rawIndex;
                }
                insertionArray[rawIndex + 1] = key;
                Thread.Sleep(delay);
                ++iter;
                showProgress(insertionArray, insertionSortGraph);
            }
            timer.Stop();
            showTime(insertionSortLabel, timer, iter);
        }
        private void shakerSortDesc()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            for (int outerLoop = 0; outerLoop < shakerArray.Length / 2; ++outerLoop)
            {
                bool swapFlag = false;
                for (int innerLoop = outerLoop; innerLoop < shakerArray.Length - outerLoop - 1; ++innerLoop)
                {
                    if (shakerArray[innerLoop] < shakerArray[innerLoop + 1])
                    {
                        swap(shakerArray, innerLoop, innerLoop + 1);
                        swapFlag = true;
                        Thread.Sleep(delay);
                        ++iter;
                        showProgress(shakerArray, shakerSortGraph);
                    }
                }
                for (int innerLoop = shakerArray.Length - 2 - outerLoop; innerLoop > outerLoop; --innerLoop)
                {
                    if (shakerArray[innerLoop - 1] < shakerArray[innerLoop])
                    {
                        swap(shakerArray, innerLoop - 1, innerLoop);
                        swapFlag = true;
                        Thread.Sleep(delay);
                        ++iter;
                        showProgress(shakerArray, shakerSortGraph);
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            timer.Stop();
            showTime(shakerSortLabel, timer, iter);
        }
        private void quickSortDesc()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            quickSort(0, quickArray.Length - 1);
            timer.Stop();
            showTime(quickSortLabel, timer, iter * (1 - 1/delay));

            void quickSort(int minIndex, int maxIndex)
            {
                if (minIndex >= maxIndex)
                {
                    return;
                }
                var pivotIndex = choosePivotDesc(quickArray, minIndex, maxIndex);
                quickSort(minIndex, (int)pivotIndex - 1);
                Thread.Sleep(delay);
                ++iter;
                showProgress(quickArray, quickSortGraph);
                quickSort((int)pivotIndex + 1, maxIndex);
                Thread.Sleep(delay);
                ++iter;
                showProgress(quickArray, quickSortGraph);
            }
        }
        double choosePivotDesc(double[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var index = minIndex; index < maxIndex; ++index)
            {
                if (array[index] > array[maxIndex])
                {
                    ++pivot;
                    swap(array, pivot, index);
                }
            }
            ++pivot;
            swap(array, pivot, maxIndex);
            return pivot;
        }
        private void bogoSortDesc()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double iter = 0;
            while (!isSortedDesc())
            {
                randomPermutation();
                Thread.Sleep(delay);
                ++iter;
                showProgress(bogoArray, bogoSortGraph);
            }
            timer.Stop();
            showTime(bogoSortLabel, timer, iter);
        }
        bool isSortedDesc()
        {
            for (int index = 0; index < bogoArray.Length - 1; ++index)
            {
                if (bogoArray[index] < bogoArray[index + 1])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}

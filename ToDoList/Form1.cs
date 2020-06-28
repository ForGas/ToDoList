using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private BindingList<TodoModel> _todoDataList;


        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private FileIOService _fileIOService;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создания или передача пути к нашему JSON Файлу
            _fileIOService = new FileIOService(PATH);


            // Попытка прочтения данных
            try
            {
                _todoDataList = _fileIOService.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }


            listBoxTask.DataSource = _todoDataList;
            listBoxTask.ValueMember = "Name";

            listBoxTask.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBoxTask.ControlAdded += ListBox1_ControlAdded;
            listBoxTask.DataSourceChanged += ListBox1_DataSourceChanged;

            
        }


        private void ListBox1_DataSourceChanged(object sender, EventArgs e)
        {

            _fileIOService.SaveData(_todoDataList);
        }

        private void ListBox1_ControlAdded(object sender, ControlEventArgs e)
        {
            _fileIOService.SaveData(_todoDataList);
        }

        // которое возникает при изменении выделенного элемента
        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // изменения даты создания
            creationData.Text = _todoDataList[listBoxTask.SelectedIndex].CreationData.ToString();

            // изменения в блокноте
            Notepad.Text = _todoDataList[listBoxTask.SelectedIndex].Notepad;


            if (_todoDataList[listBoxTask.SelectedIndex].IsDone == true)
                isDone.CheckState = CheckState.Checked;
            else
                isDone.CheckState = CheckState.Unchecked;

            // Изменения названия Файла

            _fileIOService.SaveData(_todoDataList);
        }


        private void bAddTask_Click(object sender, EventArgs e)
        {

            if (TaskName.Text != string.Empty)
            {
                if (_todoDataList == null)
                {
                    _todoDataList = new BindingList<TodoModel>()
                    {
                       new TodoModel() {Notepad = Notepad.Text, Name = TaskName.Text, IsDone =  false},
                    };
                }
                else
                {
                    TodoModel todoModel = new TodoModel()
                    { Notepad = Notepad.Text, Name = TaskName.Text, IsDone = false };
                    todoModel.Name = TaskName.Text;
                    _todoDataList.Add(todoModel);

                }

                listBoxTask.DisplayMember = "Name";
                listBoxTask.DataSource = _todoDataList;

                TaskName.Text = string.Empty;
            }

        }

        private void bAddTask_MouseMove(object sender, MouseEventArgs e)
        {
            bAddTask.BackColor = Color.FromArgb(35, 38, 37);
        }


        private void bAddTask_MouseDown(object sender, MouseEventArgs e)
        {
            bAddTask.BackColor = Color.FromArgb(14, 16, 15);
        }

        private void bAddTask_MouseLeave(object sender, EventArgs e)
        {
            bAddTask.BackColor = Color.FromArgb(14, 16, 15);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            _todoDataList.Remove(_todoDataList[listBoxTask.SelectedIndex]);

            _fileIOService.SaveData(_todoDataList);

            listBoxTask.DataSource = _todoDataList;

            listBoxTask.DisplayMember = "Name";
        }


        private void bСlose_Click(object sender, EventArgs e)
        {
            try
            {
                _fileIOService.SaveData(_todoDataList);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void Notepad_Leave(object sender, EventArgs e)
        {
            _todoDataList[listBoxTask.SelectedIndex].Notepad = Notepad.Text;

            _fileIOService.SaveData(_todoDataList);
        }



        // Notepad
        private void CreatNewDocument(object sender, EventArgs e)
        {
            Notepad.Text = "";
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    Notepad.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл");
                }
            }
        }



        // Правка
        public void CopyText()
        {
            if (Notepad.SelectedText != string.Empty)
            {
                Clipboard.SetText(Notepad.SelectedText);
            }
        }

        public void CutText()
        {
            if (Notepad.SelectedText != string.Empty)
            {
                Clipboard.SetText(Notepad.SelectedText);
                Notepad.Text = Notepad.Text.Remove(Notepad.SelectionStart, Notepad.SelectionLength);
            }     
        }

        public void PasteText()
        {
            if (Notepad.SelectedText != string.Empty)
            {
                Notepad.Text = Notepad.Text.Substring(0, Notepad.SelectionStart) + Clipboard.GetText() + Notepad.Text.Substring(Notepad.SelectionStart, Notepad.Text.Length - Notepad.SelectionStart);
            }     
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            PasteText();
        }

    }
}

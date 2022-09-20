// TODO: DRAG DROP FILE
//https://stackoverflow.com/questions/68598/how-do-i-drag-and-drop-files-into-an-application

//      public partial class Form1 : Form
//{
//    public Form1()
//    {
//        InitializeComponent();
//        this.AllowDrop = true;
//        this.DragEnter += new DragEventHandler(Form1_DragEnter);
//        this.DragDrop += new DragEventHandler(Form1_DragDrop);
//    }

//    void Form1_DragEnter(object sender, DragEventArgs e)
//    {
//        if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
//    }

//    void Form1_DragDrop(object sender, DragEventArgs e)
//    {
//        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
//        foreach (string file in files) Console.WriteLine(file);
//    }
//}
// TODO: povecaj malo slovo koje je error
using JsonValidator.App.Models;

namespace JsonValidator.App.Services
{
    public class DragDropService
    {
        private readonly IMainForm form;

        public DragDropService(IMainForm form)
        {
            this.form = form;
        }

        public void Init()
        {
            SetDropEvents((Form)form);
            SetDropEvents(form.TxtJson);
            SetDropEvents(form.TxtResult);
        }

        private void SetDropEvents(Control control)
        {
            control.AllowDrop = true;
            control.DragDrop += new DragEventHandler(FormDragDrop);
            control.DragEnter += new DragEventHandler(FormDragEnter);
        }

        private void FormDragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FormDragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            var file = files.FirstOrDefault();

            if (file == null)
            {
                return;
            }

            var content = File.ReadAllText(file);

            this.form.TxtJson.Text = content;
        }
    }
}
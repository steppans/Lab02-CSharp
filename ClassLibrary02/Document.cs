namespace ClassLibrary02
{
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Function 'Edit' is available in Pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Fuction 'Save' is available in Pro version");
        }
    }

    public class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document was edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document was saved in old format. If you want to save it in other formats buy Expert version");
        }
    }

    public class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document was saved in new format");
        }
    }
}

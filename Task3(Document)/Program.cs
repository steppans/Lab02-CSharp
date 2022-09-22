using ClassLibrary02;
Console.WriteLine("Do you have key for improving your Document Worker (yes/no)");
string answer = Console.ReadLine();

DocumentWorker worker = new DocumentWorker();

if (answer == "yes")
{
    Console.WriteLine("Enter the key:");
    string key = Console.ReadLine();

    if (key == "pro")
    {
        worker = new ProDocumentWorker();
        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }

    if (key == "exp")
    {
        worker = new ExpertDocumentWorker();
        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}

else
{
    worker.OpenDocument();
    worker.EditDocument();
    worker.SaveDocument();
}

namespace ClassLibrary02
{
    public class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(params Pupil[] new_pupils) => pupils = new_pupils;

        public void ClassInfo()
        {
            for(int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"----------Pupil #{i + 1}-----------");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }
}

using ClassLibrary02;

BadPupil Oleg =  new BadPupil();
GoodPupil Artem = new GoodPupil();
GoodPupil Petr = new GoodPupil();
ExcelentPupil Slava = new ExcelentPupil();

Pupil[] pupils = new Pupil[4] { Artem, Oleg, Petr, Slava };

ClassRoom NewClass = new ClassRoom(pupils);

NewClass.ClassInfo();

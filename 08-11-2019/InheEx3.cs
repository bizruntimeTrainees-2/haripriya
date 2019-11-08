using System;
    class Tutorial
    {
        protected string TutorialName;
            public String GetTutorial()
            {
            return TutorialName;
            }
    }
 class InheEx3 : Tutorial
    {
        public void RenameTutorial(String pNewName)
        {
            TutorialName = pNewName;
        }

        static void Main(string[] args)
        {
            InheEx3 pTutor = new InheEx3();

            pTutor.RenameTutorial(".Net by Guru99");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        }
    }

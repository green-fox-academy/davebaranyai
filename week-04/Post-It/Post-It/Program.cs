using System;

namespace Post_It
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string TextColor;
            public string Text;

        }
        static void Main(string[] args)
        {
            PostIt postit1;
            postit1.BackgroundColor = "Orange";
            postit1.TextColor = "Blue";
            postit1.TextColor = "Idea 1";

            PostIt postit2;
            postit2.BackgroundColor = "Pink";
            postit2.TextColor = "Black";
            postit2.TextColor = "Awesome";

            PostIt postit3;
            postit3.BackgroundColor = "Yellow";
            postit3.TextColor = "Green";
            postit3.TextColor = "Superb!";


        }
    }
}

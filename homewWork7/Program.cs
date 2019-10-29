using DataAccess;
using Domain;
using Microsoft.EntityFrameworkCore;
using Service;
using System;
using System.Linq;

namespace homewWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-RM1NBDJ;Database=GameData;Trusted_Connection=True;";
            ////users
            //User firstUser = new User
            //{
            //    Name = "Алексей",
            //    Age = 18
            //};
            //User secondUser = new User
            //{
            //    Name = "Максим",
            //    Age = 22
            //};
            //User thirdUser = new User
            //{
            //    Name = "Петр",
            //    Age = 28
            //};

            ////videoGames
            //VideoGame firstVideoGame = new VideoGame
            //{
            //    Name = "Fallout 4",
            //    GameInfo = "RPG"
            //};
            //VideoGame secondVideoGame = new VideoGame
            //{
            //    Name = "Ведьмак 3",
            //    GameInfo = "RPG"
            //};
            //VideoGame thirdVideoGame = new VideoGame
            //{
            //    Name = "Dota2",
            //    GameInfo = "MOBA"
            //};
            //VideoGame fourthVideoGame = new VideoGame
            //{
            //    Name = "CS GO",
            //    GameInfo = "shooter "
            //};
            //VideoGame fifthVideoGame = new VideoGame
            //{
            //    Name = "PUBG",
            //    GameInfo = "shooter "
            //};
            //VideoGame sixthVideoGame = new VideoGame
            //{
            //    Name = "FIFA 2019",
            //    GameInfo = "sport "
            //};
            //VideoGame seventhVideoGame = new VideoGame
            //{
            //    Name = "Batlefield V",
            //    GameInfo = "shooter "
            //};
            //VideoGame eighthVideoGame = new VideoGame
            //{
            //    Name = "WorldOfTanks",
            //    GameInfo = "shooter "
            //};
            //VideoGame ninthVideoGame = new VideoGame
            //{
            //    Name = "Apex Legends",
            //    GameInfo = "shooter "
            //};
            //VideoGame tenthVideoGame = new VideoGame
            //{
            //    Name = "Tom Clancy's The Division 2",
            //    GameInfo = "shooter "
            //};
            ////ratings
            //Rating firstRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = firstVideoGame,
            //    User = firstUser
            //};
            //Rating secondRating = new Rating
            //{
            //    Mark = 4,
            //    VideoGame = secondVideoGame,
            //    User = firstUser
            //};
            //Rating thirdRating = new Rating
            //{
            //    Mark = 5,
            //    VideoGame = thirdVideoGame,
            //    User = firstUser
            //};
            //Rating fourthRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = fourthVideoGame,
            //    User = firstUser
            //};
            //Rating fifthRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = fifthVideoGame,
            //    User = firstUser
            //};
            //Rating sixthRating = new Rating
            //{
            //    Mark = 4,
            //    VideoGame = sixthVideoGame,
            //    User = firstUser
            //};
            //Rating seventhRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = seventhVideoGame,
            //    User = firstUser
            //};
            //Rating eighthRating = new Rating
            //{
            //    Mark = 5,
            //    VideoGame = eighthVideoGame,
            //    User = firstUser
            //};
            //Rating ninthRating = new Rating
            //{
            //    Mark = 1,
            //    VideoGame = ninthVideoGame,
            //    User = firstUser
            //};
            //Rating tenthRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = tenthVideoGame,
            //    User = firstUser
            //};

            //Rating eleventhRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = firstVideoGame,
            //    User = secondUser
            //};
            //Rating twelfthRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = secondVideoGame,
            //    User = secondUser
            //};
            //Rating thirteenthRating = new Rating
            //{
            //    Mark = 1,
            //    VideoGame = thirdVideoGame,
            //    User = secondUser
            //};
            //Rating fourteenthRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = fourthVideoGame,
            //    User = secondUser
            //};
            //Rating fifteenthRating = new Rating
            //{
            //    Mark = 4,
            //    VideoGame = fifthVideoGame,
            //    User = secondUser
            //};
            //Rating sixteenthRating = new Rating
            //{
            //    Mark = 5,
            //    VideoGame = sixthVideoGame,
            //    User = secondUser
            //};
            //Rating seventeenthRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = seventhVideoGame,
            //    User = secondUser
            //};
            //Rating eighteenthRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = eighthVideoGame,
            //    User = secondUser
            //};
            //Rating nineteenthRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = ninthVideoGame,
            //    User = secondUser
            //};
            //Rating twentiethRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = tenthVideoGame,
            //    User = secondUser
            //};

            //Rating twentyFirstRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = firstVideoGame,
            //    User = thirdUser
            //};
            //Rating twentySecondRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = secondVideoGame,
            //    User = thirdUser
            //};
            //Rating twentythirdRating = new Rating
            //{
            //    Mark = 1,
            //    VideoGame = thirdVideoGame,
            //    User = thirdUser
            //};
            //Rating twentyFourthRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = fourthVideoGame,
            //    User = thirdUser
            //};
            //Rating twentyFifthRating = new Rating
            //{
            //    Mark = 4,
            //    VideoGame = fifthVideoGame,
            //    User = thirdUser
            //};
            //Rating twentySixthRating = new Rating
            //{
            //    Mark = 5,
            //    VideoGame = sixthVideoGame,
            //    User = thirdUser
            //};
            //Rating twentySeventhRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = seventhVideoGame,
            //    User = thirdUser
            //};
            //Rating twentyEighthRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = eighthVideoGame,
            //    User = thirdUser
            //};
            //Rating twentyNinthRating = new Rating
            //{
            //    Mark = 2,
            //    VideoGame = ninthVideoGame,
            //    User = thirdUser
            //};
            //Rating thirtiethRating = new Rating
            //{
            //    Mark = 3,
            //    VideoGame = tenthVideoGame,
            //    User = thirdUser
            //};

            //using (var context = new Context(connectionString))
            //{
            //    context.Users.Add(firstUser);
            //    context.Users.Add(secondUser);
            //    context.Users.Add(thirdUser);

            //    context.VideoGames.Add(firstVideoGame);
            //    context.VideoGames.Add(secondVideoGame);
            //    context.VideoGames.Add(thirdVideoGame);
            //    context.VideoGames.Add(fourthVideoGame);
            //    context.VideoGames.Add(fifthVideoGame);
            //    context.VideoGames.Add(sixthVideoGame);
            //    context.VideoGames.Add(seventhVideoGame);
            //    context.VideoGames.Add(eighthVideoGame);
            //    context.VideoGames.Add(ninthVideoGame);
            //    context.VideoGames.Add(tenthVideoGame);

            //    context.Ratings.Add(firstRating);
            //    context.Ratings.Add(secondRating);
            //    context.Ratings.Add(thirdRating);
            //    context.Ratings.Add(fourthRating);
            //    context.Ratings.Add(fifthRating);
            //    context.Ratings.Add(sixthRating);
            //    context.Ratings.Add(seventhRating);
            //    context.Ratings.Add(eighthRating);
            //    context.Ratings.Add(ninthRating);
            //    context.Ratings.Add(tenthRating);

            //    context.Ratings.Add(eleventhRating);
            //    context.Ratings.Add(twelfthRating);
            //    context.Ratings.Add(thirteenthRating);
            //    context.Ratings.Add(fourteenthRating);
            //    context.Ratings.Add(fifteenthRating);
            //    context.Ratings.Add(sixteenthRating);
            //    context.Ratings.Add(seventeenthRating);
            //    context.Ratings.Add(eighteenthRating);
            //    context.Ratings.Add(nineteenthRating);
            //    context.Ratings.Add(twentiethRating);

            //    context.Ratings.Add(twentyFirstRating);
            //    context.Ratings.Add(twentySecondRating);
            //    context.Ratings.Add(twentythirdRating);
            //    context.Ratings.Add(twentyFourthRating);
            //    context.Ratings.Add(twentyFifthRating);
            //    context.Ratings.Add(twentySixthRating);
            //    context.Ratings.Add(twentySeventhRating);
            //    context.Ratings.Add(twentyEighthRating);
            //    context.Ratings.Add(twentyNinthRating);
            //    context.Ratings.Add(thirtiethRating);

            //    context.SaveChanges();

            //}

            int pageSize = 3;
            int pageNumber = 0;
            Context context = new Context(connectionString);
            DataViewer viewer = new DataViewer(context);
            bool isExit = false;
            while (!isExit)
            {
                Console.Clear();
                try
                {
                    viewer.PaginationShow(pageSize, pageNumber);
                }
                catch (ArgumentOutOfRangeException excepton)
                {
                    Console.WriteLine("Ошибка, что продолжить просмотр листай страницу вперед");
                }
                Console.WriteLine("\n\n1. Следущая страница \n2. Предыдущая страница \n3. Выход");
                string action = Console.ReadLine();
                if (action == "1")
                {
                    ++pageNumber;
                }
                else if (action == "2")
                {
                    --pageNumber;
                }
                else if (action == "3")
                {
                    isExit = true;
                }
             
            }
        }
    }
}

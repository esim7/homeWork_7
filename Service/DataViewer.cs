using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Service
{
    public class DataViewer
    {
        int gameCount = 4;
        public Context DataContext { get; set; }

        public DataViewer(Context context)
        {
            this.DataContext = context;
        }
        public void PaginationShow(int pageSize, int pageNumber)
        {
          
            if (pageNumber < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var result = DataContext.VideoGames.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            foreach (var videoGame in result)
            {
                Console.WriteLine("Название игры: " + videoGame.Name);
                Console.WriteLine("Жанр: " + videoGame.GameInfo);
                Console.WriteLine("Средняя оценка " + videoGame.AverageMark);
                Console.WriteLine("--------------------------------------");  
            }
        }

    }
}

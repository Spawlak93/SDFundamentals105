using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    //POCO
    //Plain Old CSharp Object
    public class StreamingContent
    {
        public StreamingContent() { }

        public StreamingContent(string title, string description, double runTime, double reviewRating, string genre, MaturityRating ratingOfMaturity)
        {
            Title = title;
            Description = description;
            RunTime = runTime;
            ReviewRating = reviewRating;
            Genre = genre;
            RatingMaturity = ratingOfMaturity;
        }
        public string Title { get; set; }

        public string Description { get; set; }

        public double RunTime { get; set; }

        public double ReviewRating { get; set; }

        public string Genre { get; set; }

        public MaturityRating RatingMaturity { get; set; }
       
        public bool IsFamilyFriendly
        {
            get
            {
                //switch(RatingMaturity)
                //{
                //    case MaturityRating.G:
                //    case MaturityRating.PG:
                //        return true;

                //    case MaturityRating.PG13:
                //    case MaturityRating.R:
                //    case MaturityRating.NC17:
                //    case MaturityRating.NR:
                //    default:
                //        return false; 
                //}

                if((int)RatingMaturity < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public enum MaturityRating
    {
        G = 1,
        PG,
        TV_Y,
        TV_Y7,
        PG13,
        R,
        NC17,
        NR,
        TV_MA
    }

}

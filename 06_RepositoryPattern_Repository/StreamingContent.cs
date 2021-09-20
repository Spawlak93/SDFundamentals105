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

        /*
            Users have been complaining about their family friendly content. Some users have been reporting that when filtering for family friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. Currently the maturity rating and family friendly bool are independent, we need to tie them together. If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 

            We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options. Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.
        */
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

                if((int)RatingMaturity < 50)
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
        G,
        PG,
        TV_Y,
        TV_Y7,
        PG13 = 50,
        R,
        NC17,
        NR,
        TV_MA
    }

}

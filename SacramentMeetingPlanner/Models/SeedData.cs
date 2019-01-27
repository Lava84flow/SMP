using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                // Look for any Meetings.
                if (context.Meeting.Any())
                {
                    return;   // Meetings has been seeded
                }

                context.Meeting.AddRange(
                    /*
                    // Meeting Template
                    new Meeting
                    {
                        MeetingDate = DateTime.Parse(""),
                        DateUpdated = DateTime.Now,
                        Bishopric = "",
                        OpeningPrayer = "",
                        ClosingPrayer = "",
                        OpeningSong = "",
                        SacramentSong = "",
                        IntermediateSong = "",
                        ClosingSong = "",
                        Speaker = "",
                        Subject = "",
                    }
                    */

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("1981-11-15"),
                        DateUpdated = DateTime.Now,
                        Bishopric = "Billy Bob",
                        OpeningPrayer = "Adam Smith",
                        ClosingPrayer = "Old McDude",
                        OpeningSong = "#426 Don't Hit People",
                        SacramentSong = "#865 People Did Nice Things",
                        ClosingSong = "#567 Undying Love ",
                        Speaker1 = "Thing 1",
                        Subject1 = "Stuff 1",
                        Speaker2 = "Thing 47",
                        Subject2 = "Stuff 47",
                        Speaker3 = "Thing 12",
                        Subject3 = "Stuff 12",
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("1981-11-15"),
                        DateUpdated = DateTime.Now,
                        Bishopric = "Billy Bob",
                        OpeningPrayer = "Adam Smith",
                        ClosingPrayer = "Old McDude",
                        OpeningSong = "#426 Don't Hit People",
                        SacramentSong = "#865 People Did Nice Things",
                        ClosingSong = "#567 Undying Love ",
                        Speaker1 = "Thing 1",
                        Subject1 = "Stuff 1",
                        Speaker2 = "Thing 47",
                        Subject2 = "Stuff 47",
                        Speaker3 = "Thing 12",
                        Subject3 = "Stuff 12"
                    }
                );

                // Look for any Bishopric.
                if (context.Bishopric.Any())
                {
                    return;   // Bishopric has been seeded
                }

                var Bishopric = new Bishopric[]
                    {
                    //Bishopric
                    new Bishopric{FirstName="Michael",LastName="Goodrich",Calling="Bishop",},
                    new Bishopric{FirstName="Fred",LastName="Torgerson",Calling="Bishopric First Counselor",},
                    new Bishopric{FirstName="Michael",LastName="Kniephof",Calling="Bishopric Second Counselor",},
                    new Bishopric{FirstName="Andrew",LastName="Neilsen",Calling="Ward Executive Secretary",},
                    new Bishopric{FirstName="Jared",LastName="Boster",Calling="Ward Clerk",},
                    new Bishopric{FirstName="Scott",LastName="Taysom",Calling="Ward Assistant Clerk",},
                    new Bishopric{FirstName="Nolen",LastName="Brown",Calling="Ward Assistant Clerk--Membership",},
                    new Bishopric{FirstName="Chad",LastName="Hansen",Calling="Ward Assistant Clerk--Finance",},
                    new Bishopric{FirstName="Aldexander",LastName="Carson",Calling="Ward Assistant Executive Secretary",},
                    };

                foreach (Bishopric b in Bishopric)
                {
                    context.Bishopric.Add(b);
                }
                context.SaveChanges();

                // Look for any WardMembers.
                if (context.WardMember.Any())
                {
                    return;   // WardMembers has been seeded
                }

                var wardMembers = new WardMember[]
                {
                    // Relief Society
                    new WardMember{FirstName="Nicole",LastName="Dobson",Calling="Relief Society President",IsBishopric="No",},
                    new WardMember{FirstName="Anderson",LastName="Melissa",Calling="Relief Society First Counselor",IsBishopric="No",},
                    new WardMember{FirstName="Carissa",LastName="Dawn",Calling="Relief Society Second Counselor",IsBishopric="No",},
                    new WardMember{FirstName="Karina",LastName="Jackson",Calling="Relief Society Secretary",IsBishopric="No",},
                    new WardMember{FirstName="Ashley",LastName="Langford",Calling="Relief Society Meeting Coordinator",IsBishopric="No",},
                    new WardMember{FirstName="Carolyn",LastName="Beefelt",Calling="Relief Society Meeting Committee Member",IsBishopric="No",},
                    new WardMember{FirstName="Gina",LastName="Glover",Calling="Relief Society Compassionate Service Coordinator",IsBishopric="No",},
                    new WardMember{FirstName="Kelsi",LastName="Meyer",Calling="Relief Society Teacher",IsBishopric="No",},
                    new WardMember{FirstName="Trisha",LastName="Palmer",Calling="Ward Pianist",IsBishopric="No",},
                    new WardMember{FirstName="Katie",LastName="Watkins",Calling="Relief Society Teacher",IsBishopric="No",},
                    new WardMember{FirstName="Micah",LastName="Atkinson",Calling="Relief Society Activities Director",IsBishopric="No",},

                    // Elders Quorum
                    new WardMember{FirstName="Jacob",LastName="Neilsen",Calling="Elders Quorum President",IsBishopric="No",},
                    new WardMember{FirstName="Jordan",LastName="Maxwell",Calling="Elders Quorum First Counselor",IsBishopric="No",},
                    new WardMember{FirstName="Reed",LastName="Perkins",Calling="Elders Quorum Second Counselor",IsBishopric="No",},
                    new WardMember{FirstName="Jordan",LastName="Mackay",Calling="Elders Quorum Secretary",IsBishopric="No",},
                    new WardMember{FirstName="Rulon",LastName="Bailey",Calling="Elders Quorum Instructor",IsBishopric="No",},
                    new WardMember{FirstName="James",LastName="Ebert",Calling="Elders Quorum Activities Director",IsBishopric="No",},
                    new WardMember{FirstName="Chad",LastName="Hansen",Calling="Sacrament Coordinator",IsBishopric="No",},

                    // Other callings
                    new WardMember{FirstName="Christina",LastName="Furner",Calling="Sunday School Teacher",IsBishopric="No",},
                    new WardMember{FirstName="Brie",LastName="LaBaron",Calling="Organist",IsBishopric="No"},
                    new WardMember{FirstName="Andrea",LastName="Wilson",Calling="Choir Director",IsBishopric="No",}
                };

                foreach (WardMember w in wardMembers)
                {
                    context.WardMember.Add(w);
                }
                context.SaveChanges();

                // Look for any Hymns.
                if (context.Hymn.Any())
                {
                    return;   // Hymns has been seeded
                }

                string[] hymnTitles =
                {
                    "The Morning Breaks",
                    "Now Let Us Rejoice",
                    "Truth Eternal",
                    "High on the Mountain Top",
                    "Israel, Israel, God Is Calling",
                    "Come, Sing to the Lord",
                    "What Was Witnessed in the Heavens?",
                    "'Twas Witnessed in the Morning Sky*",
                    "An Angel from on High",
                    "I Saw a Mighty Angel Fly*",
                    "What Glorious Scenes Mine Eyes Behold",
                    "Awake, Ye Saints of God, Awake!",
                    "The Voice of God Again Is Heard",
                    "Come, Listen to a Prophet's Voice",
                    "We Ever Pray for Thee",
                    "God Bless Our Prophet Dear",
                    "Praise to the Man",
                    "A Poor Wayfaring Man of Grief",
                    "Come, Come, Ye Saints",
                    "Our Mountain Home So Dear",
                    "O Ye Mountains High",
                    "For the Strength of the Hills",
                    "Come, All Ye Saints of Zion",
                    "Hail to the Brightness of Zion's Glad Morning!",
                    "Zion Stands with Hills Surrounded",
                    "Lead Me into Life Eternal",
                    "We Will Sing of Zion",
                    "Glorious Things Are Sung of Zion",
                    "We're Not Ashamed to Own Our Lord",
                    "Come, O Thou King of Kings",
                    "Battle Hymn of the Republic",
                    "Raise Your Voices to the Lord",
                    "All Creatures of Our God and King*",
                    "Great King of Heaven",
                    "On This Day of Joy and Gladness",
                    "Come, All Ye Saints Who Dwell on Earth",
                    "Glory to God on High",
                    "A Mighty Fortress Is Our God",
                    "All Glory, Laud, and Honor",
                    "Praise to the Lord, the Almighty",
                    "Praise the Lord with Heart and Voice",
                    "Praise Ye the Lord",
                    "In Hymns of Praise",
                    "Great Is the Lord",
                    "God of Our Fathers, Known of Old",
                    "Press Forward, Saints",
                    "Faith of Our Fathers",
                    "God Is Love",
                    "The Lord Is My Light",
                    "From All That Dwell below the Skies",
                    "Father, Thy Children to Thee Now Raise",
                    "Come, Ye Thankful People",
                    "Dearest Children, God Is Near You",
                    "Lead, Kindly Light",
                    "I Need Thee Every Hour",
                    "Nearer, Dear Savior, to Thee",
                    "Nearer, My God, to Thee",
                    "Guide Me to Thee",
                    "Precious Savior, Dear Redeemer",
                    "Jesus, Savior, Pilot Me",
                    "The Lord Is My Shepherd",
                    "Cast Thy Burden upon the Lord",
                    "Savior, Redeemer of My Soul",
                    "Our Savior's Love",
                    "Lean on My Ample Arm",
                    "I'm a Pilgrim, I'm a Stranger",
                    "Be Still, My Soul*",
                    "How Long, O Lord Most Holy and True",
                    "Be Thou Humble",
                    "More Holiness Give Me",
                    "God Is in His Holy Temple",
                    "Father in Heaven",
                    "My Redeemer Lives",
                    "Bless Our Fast, We Pray",
                    "Jesus, the Very Thought of Thee",
                    "Let the Holy Spirit Guide*",
                    "Secret Prayer",
                    "Prayer Is the Soul's Sincere Desire",
                    "Gently Raise the Sacred Strain",
                    "Sweet Is the Work",
                    "As the Dew from Heaven Distilling",
                    "O Thou Kind and Gracious Father",
                    "Father, This Hour Has Been One of Joy",
                    "We Have Partaken of Thy Love",
                    "Before Thee, Lord, I Bow My Head",
                    "Now the Day Is Over",
                    "Lord, Dismiss Us with Thy Blessing",
                    "Great God, to Thee My Evening Song",
                    "Abide with Me; 'Tis Eventide",
                    "Come, Let Us Sing an Evening Hymn",
                    "As the Shadows Fall",
                    "God, Our Father, Hear Us Pray",
                    "In Humility, Our Savior",
                    "While of These Emblems We Partake",
                    "While of These Emblems We Partake",
                    "'Tis Sweet to Sing the Matchless Love",
                    "'Tis Sweet To Sing the Matchless Love",
                    "O Lord of Hosts",
                    "Again, Our Dear Redeeming Lord",
                    "Father in Heaven, We Do Believe",
                    "Jesus of Nazareth, Savior and King",
                    "We'll Sing All Hail to Jesus' Name",
                    "In Remembrance of Thy Suffering",
                    "God Loved Us, So He Sent His Son",
                    "Thy Will, O Lord, Be Done",
                    "O Thou, Before the World Began",
                    "Behold the Great Redeemer Die",
                    "I Stand All Amazed",
                    "How Great the Wisdom and the Love",
                    "That Easter Morn",
                    "Once in Royal David's City",
                    "Away in a Manger",
                    "O Little Town of Bethlehem",
                    "Hark!The Herald Angels Sing",
                    "With Wondering Awe",
                    "While Shepherds Watched Their Flocks",
                    "Far, Far Away on Judea's Plains",
                    "The First Noel",
                    "We Are Sowing",
                    "Come, Let Us Anew",
                    "We Give Thee But Thine Own",
                    "Lord, I Would Follow Thee",
                    "Have I Done Any Good?",
                    "We Are Marching On to Glory",
                    "Improve the Shining Moments",
                    "Scatter Sunshine",
                    "Let Us Oft Speak Kind Words",
                    "Jesus, Mighty King in Zion",
                    "Do What Is Right",
                    "Come Along, Come Along",
                    "This House We Dedicate to Thee",
                    "Onward, Christian Soldiers",
                    "We Love Thy House, O God",
                    "Up, Awake, Ye Defenders of Zion",
                    "Put Your Shoulder to the Wheel",
                    "True to the Faith",
                    "As Zion's Youth in Latter Days",
                    "O Thou Rock of Our Salvation",
                    "Thy Servants Are Prepared",
                    "How Wondrous and Great",
                    "Jehovah, Lord of Heaven and Earth",
                    "I'll Go Where You Want Me to Go",
                    "Oh Say, What Is Truth?",
                    "Truth Reflects upon Our Senses",
                    "The Iron Rod",
                    "As I Search the Holy Scriptures",
                    "Thy Holy Word",
                    "Welcome, Welcome, Sabbath Morning",
                    "Help Me Teach with Inspiration",
                    "If You Could Hie to Kolob*",
                    "Rise, Ye Saints, and Temples Enter",
                    "Rejoice, Ye Saints of Latter Days",
                    "Turn Your Hearts",
                    "Each Life That Touches Ours for Good",
                    "O Love That Glorifies the Son",
                    "Our Father, by Whose Name",
                    "From Homes of Saints Glad Songs Arise",
                    "Home Can Be a Heaven on Earth",
                    "Keep the Commandments",
                    "Love One Another",
                    "As Sisters in Zion(Women)",
                    "We Meet Again as Sisters (Women)",
                    "Sweet Is the Work(Women)",
                    "Love at Home(Women)",
                    "Ye Elders of Israel(Men)",
                    "The Priesthood of Our Lord(Men)",
                    "Ye Who Are Called to Labor(Men)",
                    "Come, All Ye Sons of God(Men)",
                    "An Angel from on High",
                    "High on the Mountain Top(Men's Choir)",
                    "I Need Thee Every Hour(Men's Choir)",
                    "Brightly Beams Our Father's Mercy (Men's Choir)",
                    "School Thy Feelings(Men's Choir)",
                    "O Home Beloved(Men's Choir)",
                    "America the Beautiful",
                    "My Country, 'Tis of Thee",
                    "The Star - Spangled Banner",
                    "God Save the King"
                };

                var Hymns = new Hymn[hymnTitles.Length];

                for (int i = 0; i < Hymns.Length; i++)
                {
                    Hymn hymn = new Hymn();
                    hymn.Title = hymnTitles[i];
                    hymn.Number = i + 1;
                    Hymns[i] = hymn;
                }

                foreach (Hymn h in Hymns)
                {
                    context.Hymn.Add(h);
                }

                context.SaveChanges();
            }
        }
    }
}

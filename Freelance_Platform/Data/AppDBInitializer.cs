using Freelance_Platform.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                //Clients
                if (!context.Clients.Any())
                {
                    context.Clients.AddRange(new List<Client>()
                    {
                       new Client()
                       {
                           FullName = "WissalCorporation",
                           Bio = "Founded in 2022",
                           Country = "Tunisia",
                           ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSBqxx-LqgP5Z09YN1Zstrp12axM-5V31SJ5XRXxrxJ-g&s",

                       },
                       new Client()
                       {
                           FullName = "Mashawino",
                           Bio = "Parties events",
                           Country = "Tunisia",
                           ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-kRiJTcNRPXIAvrcWpBdZKqyCNaCJisrSSjR2mqLE&s"
                       }
                    });
                    context.SaveChanges();

                }

                //Freelancers
                if (!context.Freelancers.Any())
                {

                    context.Freelancers.AddRange(new List<Freelancer>()
                    {
                       new Freelancer()
                       {
                           FullName = "Shayma",
                           Bio = "Software engineer from ISSAT",
                           Country = "Tunisia",
//                           FreelancerID = 15,
                           PricePerHour = 10,
                           ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSBqxx-LqgP5Z09YN1Zstrp12axM-5V31SJ5XRXxrxJ-g&s",

                       },
                       new Freelancer()
                       {
                           FullName = "Nouha",
                           Bio = "ML enthousiast",
                           Country = "Tunisia",
                          // FreelancerID = 79,
                           PricePerHour = 15,
                           ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-kRiJTcNRPXIAvrcWpBdZKqyCNaCJisrSSjR2mqLE&s"
                       }
                    });
                    context.SaveChanges();

                }
                //Talents
                if (!context.Talents.Any())
                {

                    context.Talents.AddRange(new List<Talent>()
                    {
                       new Talent()
                       {
                          // TalentID = 1,
                           Title = "Android Developer",
                           Category = TalentCategory.DevelopmentAndIT

                       },
                       new Talent()
                       {
                          // TalentID = 2,
                           Title = "Microsoft Word",
                           Category = TalentCategory.WritingAndTranslation

                       }
                    });
                    context.SaveChanges();


                }

                //Projects
                if (!context.Projects.Any())
                {

                    context.Projects.AddRange(new List<Project>()
                    {
                       new Project()
                       {
                           Country = "worldwide",
                           Title = "Android App dev",
                           Description = "developing notes app using android",
                           ExperienceLevel = "entry",
                           EstimatedDuration = 30,
                          // ProjectID = 45,
                           PostDate = DateTime.Now,
                           ClientID = 2
                           

                       },
                        new Project()
                       {
                           Country = "worldwide",
                           Title = "React App dev",
                           Description = "developing notes web app using react",
                           ExperienceLevel = "entry",
                           EstimatedDuration = 30,
                        //   ProjectID = 42,
                           PostDate = DateTime.Now.AddDays(-2),
                           ClientID = 1,

                       }                    
                    });
                    context.SaveChanges();


                }
                //Freelancers & Talents
                if (!context.Freelancers_Talents.Any())
                {

                    context.Freelancers_Talents.AddRange(new List<Freelancers_Talents>()
                    {
                       new Freelancers_Talents()
                       {
                           TalentID = 1,
                           FreelancerID = 1
                       },
                       new Freelancers_Talents()
                       {
                           TalentID = 2,
                           FreelancerID = 2
                       }

                    });
                    context.SaveChanges();
                    


                }
                //Projects & Talents
                if (!context.Projects_Talents.Any())
                {
                    context.Projects_Talents.AddRange(new List<Projects_Talents>()
                    {
                       new Projects_Talents()
                       {
                           TalentID = 1,
                           ProjectID = 1
                       },
                       new Projects_Talents()
                       {
                           TalentID = 1,
                           ProjectID = 2
                       }

                    }); ; ; ;
                    context.SaveChanges();

                }
            }
        }
    }
}

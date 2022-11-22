using CsvHelper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using Tmp.Models;
using System.Text;

namespace Tmp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        GreatChemistContext db;
        IWebHostEnvironment _appEnvironment;

        public ResultController(GreatChemistContext context, IWebHostEnvironment appEnvironment)
        {
            this.db = context;
            _appEnvironment = appEnvironment;
        }

        [HttpGet("[action]")]
        public IEnumerable<Iteration> getUserIterations(string email)
        {
            return db.Iterations
                .Where(a => a.Email == email && !a.Deleted)
                .OrderByDescending(a => a.Date)
                .ToList();
        }

        [HttpGet("[action]")]
        public UserResultsDTO getUserResults(int iteration)
        {
            DateTime date = DateTime.Now;
            List<UserResults1DTO> r1 = new List<UserResults1DTO>();
            
            List<UserAnswersType1withRightsExt> resType1 = db.UserAnswersType1withRightsExt.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType2withRightsExt> resType2 = db.UserAnswersType2withRightsExt.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType3withRightsExt> resType3 = db.UserAnswersType3withRightsExt.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType4withRightsExt> resType4 = db.UserAnswersType4withRightsExt.Where(a => a.IterationId == iteration).ToList();

            List<UserAnswersType1withRightsExt> res1 = resType1.Where(a => a.Number == 1).ToList();
            UserResults1DTO newres1 = new UserResults1DTO();
            if(res1.Count() == 84)
            {
                newres1.Number = res1[0].Number;
                newres1.OfficialNumber = res1[0].OfficialNumber;
                newres1.Title = res1[0].Title;
                newres1.Mistakes1 = res1.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres1.StartTime1 = res1[0].StartTime;
                newres1.EndTime1 = res1[0].EndTime;
                newres1.Mistakes2 = res1.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres1.StartTime2 = res1[1].StartTime;
                newres1.EndTime2 = res1[1].EndTime;
            }
            else
            {
                newres1.Number = null;
                newres1.OfficialNumber = "";
                newres1.Title = "";
                newres1.Mistakes1 = null;
                newres1.StartTime1 = date;
                newres1.EndTime1 = date;
                newres1.Mistakes2 = null;
                newres1.StartTime2 = date;
                newres1.EndTime2 = date;
            }
            r1.Add(newres1);

            List<UserAnswersType1withRightsExt> res2 = resType1.Where(a => a.Number == 2).ToList();
            UserResults1DTO newres2 = new UserResults1DTO();
            if (res2.Count() == 84)
            {
                newres2.Number = res2[0].Number;
                newres2.OfficialNumber = res2[0].OfficialNumber;
                newres2.Title = res2[0].Title;
                newres2.Mistakes1 = res2.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres2.StartTime1 = res2[0].StartTime;
                newres2.EndTime1 = res2[0].EndTime;
                newres2.Mistakes2 = res2.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres2.StartTime2 = res2[1].StartTime;
                newres2.EndTime2 = res2[1].EndTime;
            }
            else
            {
                newres2.Number = null;
                newres2.OfficialNumber = "";
                newres2.Title = "";
                newres2.Mistakes1 = null;
                newres2.StartTime1 = date;
                newres2.EndTime1 = date;
                newres2.Mistakes2 = null;
                newres2.StartTime2 = date;
                newres2.EndTime2 = date;
            }
            r1.Add(newres2);

            List<UserAnswersType1withRightsExt> res3 = resType1.Where(a => a.Number == 3).ToList();
            UserResults1DTO newres3 = new UserResults1DTO();
            if (res3.Count() == 84)
            {
                newres3.Number = res3[0].Number;
                newres3.OfficialNumber = res3[0].OfficialNumber;
                newres3.Title = res3[0].Title;
                newres3.Mistakes1 = res3.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres3.StartTime1 = res3[0].StartTime;
                newres3.EndTime1 = res3[0].EndTime;
                newres3.Mistakes2 = res3.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres3.StartTime2 = res3[1].StartTime;
                newres3.EndTime2 = res3[1].EndTime;
            }
            else
            {
                newres3.Number = null;
                newres3.OfficialNumber = "";
                newres3.Title = "";
                newres3.Mistakes1 = null;
                newres3.StartTime1 = date;
                newres3.EndTime1 = date;
                newres3.Mistakes2 = null;
                newres3.StartTime2 = date;
                newres3.EndTime2 = date;
            }
            r1.Add(newres3);

            List<UserAnswersType1withRightsExt> res4 = resType1.Where(a => a.Number == 4).ToList();
            UserResults1DTO newres4 = new UserResults1DTO();
            if (res4.Count() == 84)
            {
                newres4.Number = res4[0].Number;
                newres4.OfficialNumber = res4[0].OfficialNumber;
                newres4.Title = res4[0].Title;
                newres4.Mistakes1 = res4.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres4.StartTime1 = res4[0].StartTime;
                newres4.EndTime1 = res4[0].EndTime;
                newres4.Mistakes2 = res4.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres4.StartTime2 = res4[1].StartTime;
                newres4.EndTime2 = res4[1].EndTime;
            }
            else
            {
                newres4.Number = null;
                newres4.OfficialNumber = "";
                newres4.Title = "";
                newres4.Mistakes1 = null;
                newres4.StartTime1 = date;
                newres4.EndTime1 = date;
                newres4.Mistakes2 = null;
                newres4.StartTime2 = date;
                newres4.EndTime2 = date;
            }
            r1.Add(newres4);

            List<UserAnswersType2withRightsExt> res5 = resType2.Where(a => a.Number == 5).ToList();
            UserResults1DTO newres5 = new UserResults1DTO();
            if (res5.Count() == 84)
            {
                newres5.Number = res5[0].Number;
                newres5.OfficialNumber = res5[0].OfficialNumber;
                newres5.Title = res5[0].Title;
                newres5.Mistakes1 = res5.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres5.StartTime1 = res5[0].StartTime;
                newres5.EndTime1 = res5[0].EndTime;
                newres5.Mistakes2 = res5.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres5.StartTime2 = res5[1].StartTime;
                newres5.EndTime2 = res5[1].EndTime;
            }
            else
            {
                newres5.Number = null;
                newres5.OfficialNumber = "";
                newres5.Title = "";
                newres5.Mistakes1 = null;
                newres5.StartTime1 = date;
                newres5.EndTime1 = date;
                newres5.Mistakes2 = null;
                newres5.StartTime2 = date;
                newres5.EndTime2 = date;
            }
            r1.Add(newres5);

            List<UserAnswersType3withRightsExt> res6 = resType3.Where(a => a.Number == 6).ToList();
            UserResults1DTO newres6 = new UserResults1DTO();
            if (res6.Count() == 84)
            {
                newres6.Number = res6[0].Number;
                newres6.OfficialNumber = res6[0].OfficialNumber;
                newres6.Title = res6[0].Title;
                newres6.Mistakes1 = res6.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres6.StartTime1 = res6[0].StartTime;
                newres6.EndTime1 = res6[0].EndTime;
                newres6.Mistakes2 = res6.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres6.StartTime2 = res6[1].StartTime;
                newres6.EndTime2 = res6[1].EndTime;
            }
            else
            {
                newres6.Number = null;
                newres6.OfficialNumber = "";
                newres6.Title = "";
                newres6.Mistakes1 = null;
                newres6.StartTime1 = date;
                newres6.EndTime1 = date;
                newres6.Mistakes2 = null;
                newres6.StartTime2 = date;
                newres6.EndTime2 = date;
            }
            r1.Add(newres6);

            List<UserAnswersType1withRightsExt> res7 = resType1.Where(a => a.Number == 7).ToList();
            UserResults1DTO newres7 = new UserResults1DTO();
            if (res7.Count() == 84)
            {
                newres7.Number = res7[0].Number;
                newres7.OfficialNumber = res7[0].OfficialNumber;
                newres7.Title = res7[0].Title;
                newres7.Mistakes1 = res7.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres7.StartTime1 = res7[0].StartTime;
                newres7.EndTime1 = res7[0].EndTime;
                newres7.Mistakes2 = res7.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres7.StartTime2 = res7[1].StartTime;
                newres7.EndTime2 = res7[1].EndTime;
            }
            else
            {
                newres7.Number = null;
                newres7.OfficialNumber = "";
                newres7.Title = "";
                newres7.Mistakes1 = null;
                newres7.StartTime1 = date;
                newres7.EndTime1 = date;
                newres7.Mistakes2 = null;
                newres7.StartTime2 = date;
                newres7.EndTime2 = date;
            }
            r1.Add(newres7);

            List<UserAnswersType4withRightsExt> res8 = resType4.Where(a => a.Number == 8).ToList();
            UserResults1DTO newres8 = new UserResults1DTO();
            if (res8.Count() == 84)
            {
                newres8.Number = res8[0].Number;
                newres8.OfficialNumber = res8[0].OfficialNumber;
                newres8.Title = res8[0].Title;
                newres8.Mistakes1 = res8.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres8.StartTime1 = res8[0].StartTime;
                newres8.EndTime1 = res8[0].EndTime;
                newres8.Mistakes2 = res8.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres8.StartTime2 = res8[1].StartTime;
                newres8.EndTime2 = res8[1].EndTime;
            }
            else
            {
                newres8.Number = null;
                newres8.OfficialNumber = "";
                newres8.Title = "";
                newres8.Mistakes1 = null;
                newres8.StartTime1 = date;
                newres8.EndTime1 = date;
                newres8.Mistakes2 = null;
                newres8.StartTime2 = date;
                newres8.EndTime2 = date;
            }
            r1.Add(newres8);

            List<UserAnswersType1withRightsExt> res9 = resType1.Where(a => a.Number == 9).ToList();
            UserResults1DTO newres9 = new UserResults1DTO();
            if (res9.Count() == 84)
            {
                newres9.Number = res9[0].Number;
                newres9.OfficialNumber = res9[0].OfficialNumber;
                newres9.Title = res9[0].Title;
                newres9.Mistakes1 = res9.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres9.StartTime1 = res9[0].StartTime;
                newres9.EndTime1 = res9[0].EndTime;
                newres9.Mistakes2 = res9.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres9.StartTime2 = res9[1].StartTime;
                newres9.EndTime2 = res9[1].EndTime;
            }
            else
            {
                newres9.Number = null;
                newres9.OfficialNumber = "";
                newres9.Title = "";
                newres9.Mistakes1 = null;
                newres9.StartTime1 = date;
                newres9.EndTime1 = date;
                newres9.Mistakes2 = null;
                newres9.StartTime2 = date;
                newres9.EndTime2 = date;
            }
            r1.Add(newres9);

            List<UserAnswersType1withRightsExt> res10 = resType1.Where(a => a.Number == 10).ToList();
            UserResults1DTO newres10 = new UserResults1DTO();
            if (res10.Count() == 84)
            {
                newres10.Number = res10[0].Number;
                newres10.OfficialNumber = res10[0].OfficialNumber;
                newres10.Title = res10[0].Title;
                newres10.Mistakes1 = res10.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres10.StartTime1 = res10[0].StartTime;
                newres10.EndTime1 = res10[0].EndTime;
                newres10.Mistakes2 = res10.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres10.StartTime2 = res10[1].StartTime;
                newres10.EndTime2 = res10[1].EndTime;
            }
            else
            {
                newres10.Number = null;
                newres10.OfficialNumber = "";
                newres10.Title = "";
                newres10.Mistakes1 = null;
                newres10.StartTime1 = date;
                newres10.EndTime1 = date;
                newres10.Mistakes2 = null;
                newres10.StartTime2 = date;
                newres10.EndTime2 = date;
            }
            r1.Add(newres10);

            List<UserAnswersType1withRightsExt> res11 = resType1.Where(a => a.Number == 11).ToList();
            UserResults1DTO newres11 = new UserResults1DTO();
            if (res11.Count() == 84)
            {
                newres11.Number = res11[0].Number;
                newres11.OfficialNumber = res11[0].OfficialNumber;
                newres11.Title = res11[0].Title;
                newres11.Mistakes1 = res11.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres11.StartTime1 = res11[0].StartTime;
                newres11.EndTime1 = res11[0].EndTime;
                newres11.Mistakes2 = res11.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres11.StartTime2 = res11[1].StartTime;
                newres11.EndTime2 = res11[1].EndTime;
            }
            else
            {
                newres11.Number = null;
                newres11.OfficialNumber = "";
                newres11.Title = "";
                newres11.Mistakes1 = null;
                newres11.StartTime1 = date;
                newres11.EndTime1 = date;
                newres11.Mistakes2 = null;
                newres11.StartTime2 = date;
                newres11.EndTime2 = date;
            }
            r1.Add(newres11);

            List<UserAnswersType4withRightsExt> res12 = resType4.Where(a => a.Number == 12).ToList();
            UserResults1DTO newres12 = new UserResults1DTO();
            if (res12.Count() == 84)
            {
                newres12.Number = res12[0].Number;
                newres12.OfficialNumber = res12[0].OfficialNumber;
                newres12.Title = res12[0].Title;
                newres12.Mistakes1 = res12.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres12.StartTime1 = res12[0].StartTime;
                newres12.EndTime1 = res12[0].EndTime;
                newres12.Mistakes2 = res12.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres12.StartTime2 = res12[1].StartTime;
                newres12.EndTime2 = res12[1].EndTime;
            }
            else
            {
                newres12.Number = null;
                newres12.OfficialNumber = "";
                newres12.Title = "";
                newres12.Mistakes1 = null;
                newres12.StartTime1 = date;
                newres12.EndTime1 = date;
                newres12.Mistakes2 = null;
                newres12.StartTime2 = date;
                newres12.EndTime2 = date;
            }
            r1.Add(newres12);

            List<UserAnswersType4withRightsExt> res13 = resType4.Where(a => a.Number == 13).ToList();
            UserResults1DTO newres13 = new UserResults1DTO();
            if (res13.Count() == 84)
            {
                newres13.Number = res13[0].Number;
                newres13.OfficialNumber = res13[0].OfficialNumber;
                newres13.Title = res13[0].Title;
                newres13.Mistakes1 = res13.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
                newres13.StartTime1 = res13[0].StartTime;
                newres13.EndTime1 = res13[0].EndTime;
                newres13.Mistakes2 = res13.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
                newres13.StartTime2 = res13[1].StartTime;
                newres13.EndTime2 = res13[1].EndTime;
            }
            else
            {
                newres13.Number = null;
                newres13.OfficialNumber = "";
                newres13.Title = "";
                newres13.Mistakes1 = null;
                newres13.StartTime1 = date;
                newres13.EndTime1 = date;
                newres13.Mistakes2 = null;
                newres13.StartTime2 = date;
                newres13.EndTime2 = date;
            }
            r1.Add(newres13);

            List<UserResults2DTO> r2 = new List<UserResults2DTO>();
            List<UserAnswersType5Ext> resType5 = db.UserAnswersType5Ext.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType5Ext> res14 = resType5.Where(a => a.Number == 14).ToList();
            UserResults2DTO newres14 = new UserResults2DTO();
            if (res14.Count() == 1)
            {
                newres14.Number = res14[0].Number;
                newres14.OfficialNumber = res14[0].OfficialNumber;
                newres14.Title = res14[0].Title;
                newres14.UserAnswer = res14[0].UserAnswer;
                newres14.StartTime = res14[0].StartTime;
                newres14.EndTime = res14[0].EndTime;
            }
            else
            {
                newres14.Number = null;
                newres14.OfficialNumber = "";
                newres14.Title = "";
                newres14.UserAnswer = null;
                newres14.StartTime = date;
                newres14.EndTime = date;
            }
            r2.Add(newres14);

            List<UserAnswersType5Ext> res15 = resType5.Where(a => a.Number == 15).ToList();
            UserResults2DTO newres15 = new UserResults2DTO();
            if (res15.Count() == 1)
            {
                newres15.Number = res15[0].Number;
                newres15.OfficialNumber = res15[0].OfficialNumber;
                newres15.Title = res15[0].Title;
                newres15.UserAnswer = res15[0].UserAnswer;
                newres15.StartTime = res15[0].StartTime;
                newres15.EndTime = res15[0].EndTime;
            }
            else
            {
                newres15.Number = null;
                newres15.OfficialNumber = "";
                newres15.Title = "";
                newres15.UserAnswer = null;
                newres15.StartTime = date;
                newres15.EndTime = date;
            }
            r2.Add(newres15);

            List<UserResults3DTO> r3 = new List<UserResults3DTO>();
            IEnumerable<UserAnswersType6withRightsExt> resType6 = db.UserAnswersType6withRightsExt.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType6withRightsExt> res16 = resType6.Where(a => a.Number == 16).ToList();
            UserResults3DTO newres16 = new UserResults3DTO();
            if (res16.Count() == 1)
            {
                newres16.Number = res16[0].Number;
                newres16.OfficialNumber = res16[0].OfficialNumber;
                newres16.Title = res16[0].Title;
                newres16.IsRight = res16.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres16.StartTime = res16[0].StartTime;
                newres16.EndTime = res16[0].EndTime;
            }
            else
            {
                newres16.Number = null;
                newres16.OfficialNumber = "";
                newres16.Title = "";
                newres16.IsRight = "";
                newres16.StartTime = date;
                newres16.EndTime = date;
            }
            r3.Add(newres16);

            List<UserAnswersType6withRightsExt> res17 = resType6.Where(a => a.Number == 17).ToList();
            UserResults3DTO newres17 = new UserResults3DTO();
            if (res17.Count() == 1)
            {
                newres17.Number = res17[0].Number;
                newres17.OfficialNumber = res17[0].OfficialNumber;
                newres17.Title = res17[0].Title;
                newres17.IsRight = res17.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres17.StartTime = res17[0].StartTime;
                newres17.EndTime = res17[0].EndTime;
            }
            else
            {
                newres17.Number = null;
                newres17.OfficialNumber = "";
                newres17.Title = "";
                newres17.IsRight = "";
                newres17.StartTime = date;
                newres17.EndTime = date;
            }
            r3.Add(newres17);

            List<UserAnswersType6withRightsExt> res18 = resType6.Where(a => a.Number == 18).ToList();
            UserResults3DTO newres18 = new UserResults3DTO();
            if (res18.Count() == 1)
            {
                newres18.Number = res18[0].Number;
                newres18.OfficialNumber = res18[0].OfficialNumber;
                newres18.Title = res18[0].Title;
                newres18.IsRight = res18.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres18.StartTime = res18[0].StartTime;
                newres18.EndTime = res18[0].EndTime;
            }
            else
            {
                newres18.Number = null;
                newres18.OfficialNumber = "";
                newres18.Title = "";
                newres18.IsRight = "";
                newres18.StartTime = date;
                newres18.EndTime = date;
            }
            r3.Add(newres18);

            List<UserAnswersType6withRightsExt> res19 = resType6.Where(a => a.Number == 19).ToList();
            UserResults3DTO newres19 = new UserResults3DTO();
            if (res19.Count() == 1)
            {
                newres19.Number = res19[0].Number;
                newres19.OfficialNumber = res19[0].OfficialNumber;
                newres19.Title = res19[0].Title;
                newres19.IsRight = res19.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres19.StartTime = res19[0].StartTime;
                newres19.EndTime = res19[0].EndTime;
            }
            else
            {
                newres19.Number = null;
                newres19.OfficialNumber = "";
                newres19.Title = "";
                newres19.IsRight = "";
                newres19.StartTime = date;
                newres19.EndTime = date;
            }
            r3.Add(newres19);

            List<UserAnswersType6withRightsExt> res20 = resType6.Where(a => a.Number == 20).ToList();
            UserResults3DTO newres20 = new UserResults3DTO();
            if (res20.Count() == 1)
            {
                newres20.Number = res20[0].Number;
                newres20.OfficialNumber = res20[0].OfficialNumber;
                newres20.Title = res20[0].Title;
                newres20.IsRight = res20.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres20.StartTime = res20[0].StartTime;
                newres20.EndTime = res20[0].EndTime;
            }
            else
            {
                newres20.Number = null;
                newres20.OfficialNumber = "";
                newres20.Title = "";
                newres20.IsRight = "";
                newres20.StartTime = date;
                newres20.EndTime = date;
            }
            r3.Add(newres20);

            List<UserAnswersType6withRightsExt> res21 = resType6.Where(a => a.Number == 21).ToList();
            UserResults3DTO newres21 = new UserResults3DTO();
            if (res21.Count() == 1)
            {
                newres21.Number = res21[0].Number;
                newres21.OfficialNumber = res21[0].OfficialNumber;
                newres21.Title = res21[0].Title;
                newres21.IsRight = res21.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres21.StartTime = res21[0].StartTime;
                newres21.EndTime = res21[0].EndTime;
            }
            else
            {
                newres21.Number = null;
                newres21.OfficialNumber = "";
                newres21.Title = "";
                newres21.IsRight = "";
                newres21.StartTime = date;
                newres21.EndTime = date;
            }
            r3.Add(newres21);
        
            List<UserAnswersType6withRightsExt> res22 = resType6.Where(a => a.Number == 22).ToList();
            UserResults3DTO newres22 = new UserResults3DTO();
            if (res22.Count() == 1)
            {
                newres22.Number = res22[0].Number;
                newres22.OfficialNumber = res22[0].OfficialNumber;
                newres22.Title = res22[0].Title;
                newres22.IsRight = res22.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres22.StartTime = res22[0].StartTime;
                newres22.EndTime = res22[0].EndTime;
            }
            else
            {
                newres22.Number = null;
                newres22.OfficialNumber = "";
                newres22.Title = "";
                newres22.IsRight = "";
                newres22.StartTime = date;
                newres22.EndTime = date;
            }
            r3.Add(newres22);

            List<UserAnswersType6withRightsExt> res23 = resType6.Where(a => a.Number == 23).ToList();
            UserResults3DTO newres23 = new UserResults3DTO();
            if (res23.Count() == 1)
            {
                newres23.Number = res23[0].Number;
                newres23.OfficialNumber = res23[0].OfficialNumber;
                newres23.Title = res23[0].Title;
                newres23.IsRight = res23.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres23.StartTime = res23[0].StartTime;
                newres23.EndTime = res23[0].EndTime;
            }
            else
            {
                newres23.Number = null;
                newres23.OfficialNumber = "";
                newres23.Title = "";
                newres23.IsRight = "";
                newres23.StartTime = date;
                newres23.EndTime = date;
            }
            r3.Add(newres23);

            List<UserAnswersType6withRightsExt> res24 = resType6.Where(a => a.Number == 24).ToList();
            UserResults3DTO newres24 = new UserResults3DTO();
            if (res24.Count() == 1)
            {
                newres24.Number = res24[0].Number;
                newres24.OfficialNumber = res24[0].OfficialNumber;
                newres24.Title = res24[0].Title;
                newres24.IsRight = res24.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres24.StartTime = res24[0].StartTime;
                newres24.EndTime = res24[0].EndTime;
            }
            else
            {
                newres24.Number = null;
                newres24.OfficialNumber = "";
                newres24.Title = "";
                newres24.IsRight = "";
                newres24.StartTime = date;
                newres24.EndTime = date;
            }
            r3.Add(newres24);

            List<UserAnswersType6withRightsExt> res25 = resType6.Where(a => a.Number == 25).ToList();
            UserResults3DTO newres25 = new UserResults3DTO();
            if (res25.Count() == 1)
            {
                newres25.Number = res25[0].Number;
                newres25.OfficialNumber = res25[0].OfficialNumber;
                newres25.Title = res25[0].Title;
                newres25.IsRight = res25.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres25.StartTime = res25[0].StartTime;
                newres25.EndTime = res25[0].EndTime;
            }
            else
            {
                newres25.Number = null;
                newres25.OfficialNumber = "";
                newres25.Title = "";
                newres25.IsRight = "";
                newres25.StartTime = date;
                newres25.EndTime = date;
            }
            r3.Add(newres25);

            List<UserAnswersType6withRightsExt> res26 = resType6.Where(a => a.Number == 26).ToList();
            UserResults3DTO newres26 = new UserResults3DTO();
            if (res26.Count() == 1)
            {
                newres26.Number = res26[0].Number;
                newres26.OfficialNumber = res26[0].OfficialNumber;
                newres26.Title = res26[0].Title;
                newres26.IsRight = res26.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres26.StartTime = res26[0].StartTime;
                newres26.EndTime = res26[0].EndTime;
            }
            else
            {
                newres26.Number = null;
                newres26.OfficialNumber = "";
                newres26.Title = "";
                newres26.IsRight = "";
                newres26.StartTime = date;
                newres26.EndTime = date;
            }
            r3.Add(newres26);

            List<UserAnswersType6withRightsExt> res27 = resType6.Where(a => a.Number == 27).ToList();
            UserResults3DTO newres27 = new UserResults3DTO();
            if (res27.Count() == 1)
            {
                newres27.Number = res27[0].Number;
                newres27.OfficialNumber = res27[0].OfficialNumber;
                newres27.Title = res27[0].Title;
                newres27.IsRight = res27.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres27.StartTime = res27[0].StartTime;
                newres27.EndTime = res27[0].EndTime;
            }
            else
            {
                newres27.Number = null;
                newres27.OfficialNumber = "";
                newres27.Title = "";
                newres27.IsRight = "";
                newres27.StartTime = date;
                newres27.EndTime = date;
            }
            r3.Add(newres27);

            List<UserAnswersType6withRightsExt> res28 = resType6.Where(a => a.Number == 28).ToList();
            UserResults3DTO newres28 = new UserResults3DTO();
            if (res28.Count() == 1)
            {
                newres28.Number = res28[0].Number;
                newres28.OfficialNumber = res28[0].OfficialNumber;
                newres28.Title = res28[0].Title;
                newres28.IsRight = res28.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres28.StartTime = res28[0].StartTime;
                newres28.EndTime = res28[0].EndTime;
            }
            else
            {
                newres28.Number = null;
                newres28.OfficialNumber = "";
                newres28.Title = "";
                newres28.IsRight = "";
                newres28.StartTime = date;
                newres28.EndTime = date;
            }
            r3.Add(newres28);

            List<UserAnswersType6withRightsExt> res29 = resType6.Where(a => a.Number == 29).ToList();
            UserResults3DTO newres29 = new UserResults3DTO();
            if (res29.Count() == 1)
            {
                newres29.Number = res29[0].Number;
                newres29.OfficialNumber = res29[0].OfficialNumber;
                newres29.Title = res29[0].Title;
                newres29.IsRight = res29.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres29.StartTime = res29[0].StartTime;
                newres29.EndTime = res29[0].EndTime;
            }
            else
            {
                newres29.Number = null;
                newres29.OfficialNumber = "";
                newres29.Title = "";
                newres29.IsRight = "";
                newres29.StartTime = date;
                newres29.EndTime = date;
            }
            r3.Add(newres29);

            List<UserAnswersType6withRightsExt> res30 = resType6.Where(a => a.Number == 30).ToList();
            UserResults3DTO newres30 = new UserResults3DTO();
            if (res30.Count() == 1)
            {
                newres30.Number = res30[0].Number;
                newres30.OfficialNumber = res30[0].OfficialNumber;
                newres30.Title = res30[0].Title;
                newres30.IsRight = res30.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres30.StartTime = res30[0].StartTime;
                newres30.EndTime = res30[0].EndTime;
            }
            else
            {
                newres30.Number = null;
                newres30.OfficialNumber = "";
                newres30.Title = "";
                newres30.IsRight = "";
                newres30.StartTime = date;
                newres30.EndTime = date;
            }
            r3.Add(newres30);

            List<UserAnswersType6withRightsExt> res31 = resType6.Where(a => a.Number == 31).ToList();
            UserResults3DTO newres31 = new UserResults3DTO();
            if (res31.Count() == 1)
            {
                newres31.Number = res31[0].Number;
                newres31.OfficialNumber = res31[0].OfficialNumber;
                newres31.Title = res31[0].Title;
                newres31.IsRight = res31.Where(a => a.UserAnswer1 == a.Right1 && a.UserAnswer2 == a.Right2 && a.UserAnswer3 == a.Right3).Count() > 0 ? "Да" : "Нет";
                newres31.StartTime = res31[0].StartTime;
                newres31.EndTime = res31[0].EndTime;
            }
            else
            {
                newres31.Number = null;
                newres31.OfficialNumber = "";
                newres31.Title = "";
                newres31.IsRight = "";
                newres31.StartTime = date;
                newres31.EndTime = date;
            }
            r3.Add(newres31);

            UserResultsDTO res = new UserResultsDTO();
            res.R1 = r1;
            res.R2 = r2;
            res.R3 = r3;

            string path = _appEnvironment.WebRootPath + @"\results.csv";
            string delimiter = "; ";

            System.IO.File.WriteAllText(path, string.Empty, Encoding.UTF8);

            Iteration i = db.Iterations.Find(iteration);

            string appendText = i.Email + delimiter + i.Date + delimiter + Environment.NewLine;
            appendText = appendText + Environment.NewLine;

            appendText = appendText + "Задание" + delimiter + "Ошибки" + delimiter + "Время" + delimiter + "Ошибки" + delimiter + "Время" + Environment.NewLine;
            System.IO.File.AppendAllText(path, appendText, Encoding.UTF8);

            foreach(UserResults1DTO a in r1)
            {
                var dif1 = (a.EndTime1 - a.StartTime1).Duration();
                var h1 = dif1.Hours < 10 ? '0'+ dif1.Hours.ToString() : dif1.Hours.ToString();
                var m1 = dif1.Minutes < 10 ? '0' + dif1.Minutes.ToString() : dif1.Minutes.ToString();
                var s1 = dif1.Seconds < 10 ? '0' + dif1.Seconds.ToString() : dif1.Seconds.ToString();
                var dif2 = (a.EndTime2 - a.StartTime2).Duration();
                var h2 = dif2.Hours < 10 ? '0' + dif2.Hours.ToString() : dif2.Hours.ToString();
                var m2 = dif2.Minutes < 10 ? '0' + dif2.Minutes.ToString() : dif2.Minutes.ToString();
                var s2 = dif2.Seconds < 10 ? '0' + dif2.Seconds.ToString() : dif2.Seconds.ToString();
                appendText = a.OfficialNumber + ". " + a.Title + delimiter + a.Mistakes1 + delimiter + h1 + ":" + m1 + ":" + s1 + delimiter + a.Mistakes2 + delimiter + h2 + ":" + m2 + ":" + s2 + Environment.NewLine;
                System.IO.File.AppendAllText(path, appendText, Encoding.UTF8);
            }

            appendText = Environment.NewLine;
            appendText = appendText + "Задание" + delimiter + "Время" + delimiter + "Ответ" + Environment.NewLine;
            System.IO.File.AppendAllText(path, appendText, Encoding.UTF8);

            foreach (UserResults2DTO a in r2)
            {
                var dif = (a.EndTime - a.StartTime).Duration();
                var h = dif.Hours < 10 ? '0' + dif.Hours.ToString() : dif.Hours.ToString();
                var m = dif.Minutes < 10 ? '0' + dif.Minutes.ToString() : dif.Minutes.ToString();
                var s = dif.Seconds < 10 ? '0' + dif.Seconds.ToString() : dif.Seconds.ToString();
                appendText = a.OfficialNumber + ". " + a.Title + delimiter + h + ":" + m + ":" + s + delimiter + a.UserAnswer + Environment.NewLine;
                System.IO.File.AppendAllText(path, appendText, Encoding.UTF8);
            }

            appendText = Environment.NewLine;
            appendText = appendText + "Арифметический субтест" + delimiter + "Верно" + delimiter + "Время" + Environment.NewLine;
            System.IO.File.AppendAllText(path, appendText, Encoding.UTF8);

            foreach (UserResults3DTO a in r3)
            {
                var dif = (a.EndTime - a.StartTime).Duration();
                var h = dif.Hours < 10 ? '0' + dif.Hours.ToString() : dif.Hours.ToString();
                var m = dif.Minutes < 10 ? '0' + dif.Minutes.ToString() : dif.Minutes.ToString();
                var s = dif.Seconds < 10 ? '0' + dif.Seconds.ToString() : dif.Seconds.ToString();
                appendText = a.OfficialNumber + ". " + a.Title + delimiter + a.IsRight + delimiter + h + ":" + m + ":" + s + Environment.NewLine;
                System.IO.File.AppendAllText(path, appendText, Encoding.UTF8);
            }

            return res;
        }
    }
}

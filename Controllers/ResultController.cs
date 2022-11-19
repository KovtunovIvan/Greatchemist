using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tmp.Models;

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
        public List<UserResultsDTO> getUserResults(int iteration)
        {
            List<UserResultsDTO> res = new List<UserResultsDTO>();
            
            List<UserAnswersType1withRightsExt> resType1 = db.UserAnswersType1withRightsExt.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType2withRightsExt> resType2 = db.UserAnswersType2withRightsExt.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType3withRightsExt> resType3 = db.UserAnswersType3withRightsExt.Where(a => a.IterationId == iteration).ToList();
            List<UserAnswersType4withRightsExt> resType4 = db.UserAnswersType4withRightsExt.Where(a => a.IterationId == iteration).ToList();

            List<UserAnswersType1withRightsExt> res1 = resType1.Where(a => a.Number == 1).ToList();
            UserResultsDTO newres1_1 = new UserResultsDTO();
            newres1_1.Parallel = res1[0].Parallel;
            newres1_1.Mistakes = res1.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres1_1.Number = res1[0].Number;
            newres1_1.OfficialNumber = res1[0].OfficialNumber;
            newres1_1.Title = res1[0].Title;
            newres1_1.StartTime = res1[0].StartTime;
            newres1_1.EndTime = res1[0].EndTime;
            res.Add(newres1_1);
            UserResultsDTO newres1_2 = new UserResultsDTO();
            newres1_2.Parallel = res1[1].Parallel;
            newres1_2.Mistakes = res1.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres1_2.Number = res1[1].Number;
            newres1_2.OfficialNumber = res1[1].OfficialNumber;
            newres1_2.Title = res1[1].Title;
            newres1_2.StartTime = res1[1].StartTime;
            newres1_2.EndTime = res1[1].EndTime;
            res.Add(newres1_2);

            List<UserAnswersType1withRightsExt> res2 = resType1.Where(a => a.Number == 2).ToList();
            UserResultsDTO newres2_1 = new UserResultsDTO();
            newres2_1.Parallel = res2[0].Parallel;
            newres2_1.Mistakes = res2.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres2_1.Number = res2[0].Number;
            newres2_1.OfficialNumber = res2[0].OfficialNumber;
            newres2_1.Title = res2[0].Title;
            newres2_1.StartTime = res2[0].StartTime;
            newres2_1.EndTime = res2[0].EndTime;
            res.Add(newres2_1);
            UserResultsDTO newres2_2 = new UserResultsDTO();
            newres2_2.Parallel = res2[1].Parallel;
            newres2_2.Mistakes = res2.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres2_2.Number = res2[1].Number;
            newres2_2.OfficialNumber = res2[1].OfficialNumber;
            newres2_2.Title = res2[1].Title;
            newres2_2.StartTime = res2[1].StartTime;
            newres2_2.EndTime = res2[1].EndTime;
            res.Add(newres2_2);

            List<UserAnswersType1withRightsExt> res3 = resType1.Where(a => a.Number == 3).ToList();
            UserResultsDTO newres3_1 = new UserResultsDTO();
            newres3_1.Parallel = res3[0].Parallel;
            newres3_1.Mistakes = res3.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres3_1.Number = res3[0].Number;
            newres3_1.OfficialNumber = res3[0].OfficialNumber;
            newres3_1.Title = res3[0].Title;
            newres3_1.StartTime = res3[0].StartTime;
            newres3_1.EndTime = res3[0].EndTime;
            res.Add(newres3_1);
            UserResultsDTO newres3_2 = new UserResultsDTO();
            newres3_2.Parallel = res3[1].Parallel;
            newres3_2.Mistakes = res3.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres3_2.Number = res3[1].Number;
            newres3_2.OfficialNumber = res3[1].OfficialNumber;
            newres3_2.Title = res3[1].Title;
            newres3_2.StartTime = res3[1].StartTime;
            newres3_2.EndTime = res3[1].EndTime;
            res.Add(newres3_2);

            List<UserAnswersType1withRightsExt> res4 = resType1.Where(a => a.Number == 4).ToList();
            UserResultsDTO newres4_1 = new UserResultsDTO();
            newres4_1.Parallel = res4[0].Parallel;
            newres4_1.Mistakes = res4.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres4_1.Number = res4[0].Number;
            newres4_1.OfficialNumber = res4[0].OfficialNumber;
            newres4_1.Title = res4[0].Title;
            newres4_1.StartTime = res4[0].StartTime;
            newres4_1.EndTime = res4[0].EndTime;
            res.Add(newres4_1);
            UserResultsDTO newres4_2 = new UserResultsDTO();
            newres4_2.Parallel = res4[1].Parallel;
            newres4_2.Mistakes = res4.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres4_2.Number = res4[1].Number;
            newres4_2.OfficialNumber = res4[1].OfficialNumber;
            newres4_2.Title = res4[1].Title;
            newres4_2.StartTime = res4[1].StartTime;
            newres4_2.EndTime = res4[1].EndTime;
            res.Add(newres4_2);

            List<UserAnswersType2withRightsExt> res5 = resType2.Where(a => a.Number == 5).ToList();
            UserResultsDTO newres5_1 = new UserResultsDTO();
            newres5_1.Parallel = res5[0].Parallel;
            newres5_1.Mistakes = res5.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres5_1.Number = res5[0].Number;
            newres5_1.OfficialNumber = res5[0].OfficialNumber;
            newres5_1.Title = res5[0].Title;
            newres5_1.StartTime = res5[0].StartTime;
            newres5_1.EndTime = res5[0].EndTime;
            res.Add(newres5_1);
            UserResultsDTO newres5_2 = new UserResultsDTO();
            newres5_2.Parallel = res5[1].Parallel;
            newres5_2.Mistakes = res5.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres5_2.Number = res5[1].Number;
            newres5_2.OfficialNumber = res5[1].OfficialNumber;
            newres5_2.Title = res5[1].Title;
            newres5_2.StartTime = res5[1].StartTime;
            newres5_2.EndTime = res5[1].EndTime;
            res.Add(newres5_2);

            List<UserAnswersType3withRightsExt> res6 = resType3.Where(a => a.Number == 6).ToList();
            UserResultsDTO newres6_1 = new UserResultsDTO();
            newres6_1.Parallel = res6[0].Parallel;
            newres6_1.Mistakes = res6.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres6_1.Number = res6[0].Number;
            newres6_1.OfficialNumber = res6[0].OfficialNumber;
            newres6_1.Title = res6[0].Title;
            newres6_1.StartTime = res6[0].StartTime;
            newres6_1.EndTime = res6[0].EndTime;
            res.Add(newres6_1);
            UserResultsDTO newres6_2 = new UserResultsDTO();
            newres6_2.Parallel = res6[1].Parallel;
            newres6_2.Mistakes = res6.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres6_2.Number = res6[1].Number;
            newres6_2.OfficialNumber = res6[1].OfficialNumber;
            newres6_2.Title = res6[1].Title;
            newres6_2.StartTime = res6[1].StartTime;
            newres6_2.EndTime = res6[1].EndTime;
            res.Add(newres6_2);

            List<UserAnswersType1withRightsExt> res7 = resType1.Where(a => a.Number == 7).ToList();
            UserResultsDTO newres7_1 = new UserResultsDTO();
            newres7_1.Parallel = res7[0].Parallel;
            newres7_1.Mistakes = res7.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres7_1.Number = res7[0].Number;
            newres7_1.OfficialNumber = res7[0].OfficialNumber;
            newres7_1.Title = res7[0].Title;
            newres7_1.StartTime = res7[0].StartTime;
            newres7_1.EndTime = res7[0].EndTime;
            res.Add(newres7_1);
            UserResultsDTO newres7_2 = new UserResultsDTO();
            newres7_2.Parallel = res7[1].Parallel;
            newres7_2.Mistakes = res7.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres7_2.Number = res7[1].Number;
            newres7_2.OfficialNumber = res7[1].OfficialNumber;
            newres7_2.Title = res7[1].Title;
            newres7_2.StartTime = res7[1].StartTime;
            newres7_2.EndTime = res7[1].EndTime;
            res.Add(newres7_2);

            List<UserAnswersType4withRightsExt> res8 = resType4.Where(a => a.Number == 8).ToList();
            UserResultsDTO newres8_1 = new UserResultsDTO();
            newres8_1.Parallel = res8[0].Parallel;
            newres8_1.Mistakes = res8.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres8_1.Number = res8[0].Number;
            newres8_1.OfficialNumber = res8[0].OfficialNumber;
            newres8_1.Title = res8[0].Title;
            newres8_1.StartTime = res8[0].StartTime;
            newres8_1.EndTime = res8[0].EndTime;
            res.Add(newres8_1);
            UserResultsDTO newres8_2 = new UserResultsDTO();
            newres8_2.Parallel = res8[1].Parallel;
            newres8_2.Mistakes = res8.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres8_2.Number = res8[1].Number;
            newres8_2.OfficialNumber = res8[1].OfficialNumber;
            newres8_2.Title = res8[1].Title;
            newres8_2.StartTime = res8[1].StartTime;
            newres8_2.EndTime = res8[1].EndTime;
            res.Add(newres8_2);

            List<UserAnswersType1withRightsExt> res9 = resType1.Where(a => a.Number == 9).ToList();
            UserResultsDTO newres9_1 = new UserResultsDTO();
            newres9_1.Parallel = res9[0].Parallel;
            newres9_1.Mistakes = res9.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres9_1.Number = res9[0].Number;
            newres9_1.OfficialNumber = res9[0].OfficialNumber;
            newres9_1.Title = res9[0].Title;
            newres9_1.StartTime = res9[0].StartTime;
            newres9_1.EndTime = res9[0].EndTime;
            res.Add(newres9_1);
            UserResultsDTO newres9_2 = new UserResultsDTO();
            newres9_2.Parallel = res9[1].Parallel;
            newres9_2.Mistakes = res9.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres9_2.Number = res9[1].Number;
            newres9_2.OfficialNumber = res9[1].OfficialNumber;
            newres9_2.Title = res9[1].Title;
            newres9_2.StartTime = res9[1].StartTime;
            newres9_2.EndTime = res9[1].EndTime;
            res.Add(newres9_2);

            List<UserAnswersType1withRightsExt> res10 = resType1.Where(a => a.Number == 10).ToList();
            UserResultsDTO newres10_1 = new UserResultsDTO();
            newres10_1.Parallel = res10[0].Parallel;
            newres10_1.Mistakes = res10.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres10_1.Number = res10[0].Number;
            newres10_1.OfficialNumber = res10[0].OfficialNumber;
            newres10_1.Title = res10[0].Title;
            newres10_1.StartTime = res10[0].StartTime;
            newres10_1.EndTime = res10[0].EndTime;
            res.Add(newres10_1);
            UserResultsDTO newres10_2 = new UserResultsDTO();
            newres10_2.Parallel = res10[1].Parallel;
            newres10_2.Mistakes = res10.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres10_2.Number = res10[1].Number;
            newres10_2.OfficialNumber = res10[1].OfficialNumber;
            newres10_2.Title = res10[1].Title;
            newres10_2.StartTime = res10[1].StartTime;
            newres10_2.EndTime = res10[1].EndTime;
            res.Add(newres10_2);

            List<UserAnswersType1withRightsExt> res11 = resType1.Where(a => a.Number == 11).ToList();
            UserResultsDTO newres11_1 = new UserResultsDTO();
            newres11_1.Parallel = res11[0].Parallel;
            newres11_1.Mistakes = res11.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres11_1.Number = res11[0].Number;
            newres11_1.OfficialNumber = res11[0].OfficialNumber;
            newres11_1.Title = res11[0].Title;
            newres11_1.StartTime = res11[0].StartTime;
            newres11_1.EndTime = res11[0].EndTime;
            res.Add(newres11_1);
            UserResultsDTO newres11_2 = new UserResultsDTO();
            newres11_2.Parallel = res11[1].Parallel;
            newres11_2.Mistakes = res11.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres11_2.Number = res11[1].Number;
            newres11_2.OfficialNumber = res11[1].OfficialNumber;
            newres11_2.Title = res11[1].Title;
            newres11_2.StartTime = res11[1].StartTime;
            newres11_2.EndTime = res11[1].EndTime;
            res.Add(newres11_2);

            List<UserAnswersType4withRightsExt> res12 = resType4.Where(a => a.Number == 12).ToList();
            UserResultsDTO newres12_1 = new UserResultsDTO();
            newres12_1.Parallel = res12[0].Parallel;
            newres12_1.Mistakes = res12.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres12_1.Number = res12[0].Number;
            newres12_1.OfficialNumber = res12[0].OfficialNumber;
            newres12_1.Title = res12[0].Title;
            newres12_1.StartTime = res12[0].StartTime;
            newres12_1.EndTime = res12[0].EndTime;
            res.Add(newres12_1);
            UserResultsDTO newres12_2 = new UserResultsDTO();
            newres12_2.Parallel = res12[1].Parallel;
            newres12_2.Mistakes = res12.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres12_2.Number = res12[1].Number;
            newres12_2.OfficialNumber = res12[1].OfficialNumber;
            newres12_2.Title = res12[1].Title;
            newres12_2.StartTime = res12[1].StartTime;
            newres12_2.EndTime = res12[1].EndTime;
            res.Add(newres12_2);

            List<UserAnswersType4withRightsExt> res13 = resType4.Where(a => a.Number == 13).ToList();
            UserResultsDTO newres13_1 = new UserResultsDTO();
            newres13_1.Parallel = res13[0].Parallel;
            newres13_1.Mistakes = res13.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 1).Count();
            newres13_1.Number = res13[0].Number;
            newres13_1.OfficialNumber = res13[0].OfficialNumber;
            newres13_1.Title = res13[0].Title;
            newres13_1.StartTime = res13[0].StartTime;
            newres13_1.EndTime = res13[0].EndTime;
            res.Add(newres13_1);
            UserResultsDTO newres13_2 = new UserResultsDTO();
            newres13_2.Parallel = res13[1].Parallel;
            newres13_2.Mistakes = res13.Where(a => a.RightBtn != a.UserAnswer && a.Parallel == 2).Count();
            newres13_2.Number = res13[1].Number;
            newres13_2.OfficialNumber = res13[1].OfficialNumber;
            newres13_2.Title = res13[1].Title;
            newres13_2.StartTime = res13[1].StartTime;
            newres13_2.EndTime = res13[1].EndTime;
            res.Add(newres13_2);

            return res;

            //IEnumerable<UserAnswersType6withRightsExt> resType6 = db.UserAnswersType6withRightsExt.Where(a => a.IterationId == iteration).ToList();
        }
    }
}

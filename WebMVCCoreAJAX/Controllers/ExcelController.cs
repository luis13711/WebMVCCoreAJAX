using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMVCCoreAJAX.Models;
//using ClosedXML.Excel;
//using ClosedXML;
using System.IO;
//EPPLUS 4.5.1
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;

namespace WebMVCCoreAJAX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        private readonly WorkoutContext _db;
        public ExcelController(WorkoutContext db)
        {
            _db = db;
        }

        [HttpGet("ExportarExcel")]
        public IActionResult ExportarExcel()
        {
            //_db.Books.ToList();

            //using (XLWorkbook wb = new XLWorkbook())
            //{
            //    wb.Worksheets.Add(_db.Books.ToList());
            //    wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            //    wb.Style.Font.Bold = true;

            //    Response.Clear();
            //    Response.Buffer = true;
            //    Response.Charset = "";
            //    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //    Response.AddHeader("content-disposition", "attachment;filename= EmployeeReport.xlsx");

            //    using (MemoryStream MyMemoryStream = new MemoryStream())
            //    {
            //        wb.SaveAs(MyMemoryStream);
            //        MyMemoryStream.WriteTo(Response.OutputStream);
            //        Response.Flush();
            //        Response.End();
            //    }
            //}

            byte[] fileContents;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                // _db.Books.ToList()
                // Put whatever you want here in the sheet
                // For example, for cell on row1 col1


                //worksheet.Cells[1, 1].Value = "Long text";
                //worksheet.Cells[1, 1].Style.Font.Size = 12;
                //worksheet.Cells[1, 1].Style.Font.Bold = true;
                //worksheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                DataTable dt = new DataTable("Customers");

                DataColumn workCol = dt.Columns.Add("ID", typeof(Int32));
                workCol.AllowDBNull = false;
                workCol.Unique = true;

                dt.Columns.Add("Name", typeof(String));
                DataRow row;
                foreach (Book book in _db.Books.ToList())
                {
                    row = dt.NewRow();
                    row["ID"] = book.Id;
                    row["Name"] = book.Name;
                    dt.Rows.Add(row);
                }
                //_db.Books.ToList()

                worksheet.Cells["A1"].LoadFromDataTable(dt, true);

                // So many things you can try but you got the idea.

                // Finally when you're done, export it to byte array.
                fileContents = package.GetAsByteArray();
            }

            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: "test.xlsx"
            );

            //return new JsonResult(_db.Books.ToList());
        }

    }
}
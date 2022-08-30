
using Microsoft.EntityFrameworkCore.Migrations;

namespace Struggle.Seed
{
    public static class MigrationBuilderExtension
    {
        public static void MigrateVehicle(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Cars",
                                        new string[] { "Id", "Name", "Color" ,"HeadLights","IsDeleted","Wheel"},
                                        new object[]
                                        {
                                            "35435A56-2985-4A90-BF20-87ABC1D87A26","Volvo",1,true,false,1
                                        });
            migrationBuilder.InsertData("Buses",
                                       new string[] { "Id", "Name", "Color", "IsDeleted" },
                                       new object[]
                                       {
                                               "64F15E29-B26D-4050-B457-5F788A2F0C28","BoozeBus",2,false
                                       });
            migrationBuilder.InsertData("Boats",
                                       new string[] { "Id", "Name", "Color", "IsDeleted" },
                                       new object[]
                                       {
                                       "6289634F-7D36-4D5B-99E5-E354DC5EF84A","TugBoat",3,false
                                       });


        }
    }
}

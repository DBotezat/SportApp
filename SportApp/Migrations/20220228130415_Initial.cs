using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationOfActivity = table.Column<int>(type: "int", nullable: false),
                    NumberOfTrainingsWeek = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfDiet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiseaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeOfFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountOfFoodPerDay = table.Column<int>(type: "int", nullable: false),
                    CountOfKcal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfTraining = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimingOfTraining = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogIn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogIn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TraningPlanId = table.Column<int>(type: "int", nullable: false),
                    DietPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalAccounts_DietPlan_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalAccounts_TrainingPlans_TraningPlanId",
                        column: x => x.TraningPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRespondes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserLogInId = table.Column<int>(type: "int", nullable: false),
                    DietPlanId = table.Column<int>(type: "int", nullable: false),
                    TrainingPlanId = table.Column<int>(type: "int", nullable: false),
                    DiseasesId = table.Column<int>(type: "int", nullable: false),
                    TypeOfActivityId = table.Column<int>(type: "int", nullable: false),
                    TypeOfFoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRespondes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRespondes_ActivityType_TypeOfActivityId",
                        column: x => x.TypeOfActivityId,
                        principalTable: "ActivityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRespondes_DietPlan_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRespondes_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRespondes_FoodType_TypeOfFoodId",
                        column: x => x.TypeOfFoodId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRespondes_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRespondes_UserLogIn_UserLogInId",
                        column: x => x.UserLogInId,
                        principalTable: "UserLogIn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAccounts_DietPlanId",
                table: "PersonalAccounts",
                column: "DietPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAccounts_TraningPlanId",
                table: "PersonalAccounts",
                column: "TraningPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRespondes_DietPlanId",
                table: "UserRespondes",
                column: "DietPlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRespondes_DiseasesId",
                table: "UserRespondes",
                column: "DiseasesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRespondes_TrainingPlanId",
                table: "UserRespondes",
                column: "TrainingPlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRespondes_TypeOfActivityId",
                table: "UserRespondes",
                column: "TypeOfActivityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRespondes_TypeOfFoodId",
                table: "UserRespondes",
                column: "TypeOfFoodId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRespondes_UserLogInId",
                table: "UserRespondes",
                column: "UserLogInId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalAccounts");

            migrationBuilder.DropTable(
                name: "UserRespondes");

            migrationBuilder.DropTable(
                name: "ActivityType");

            migrationBuilder.DropTable(
                name: "DietPlan");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "TrainingPlans");

            migrationBuilder.DropTable(
                name: "UserLogIn");
        }
    }
}

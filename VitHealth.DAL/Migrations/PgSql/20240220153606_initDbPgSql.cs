using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VitHealth.DAL.Migrations.PgSql
{
    /// <inheritdoc />
    public partial class initDbPgSql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PatientSurname = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    IdentificationNumber = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Password = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 2, 20, 18, 36, 6, 396, DateTimeKind.Utc).AddTicks(8472)),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Policlinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PoliclinicName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 2, 20, 18, 36, 6, 396, DateTimeKind.Utc).AddTicks(9694)),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policlinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SymptomName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 2, 20, 18, 36, 6, 397, DateTimeKind.Utc).AddTicks(1215)),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DiseaseName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 2, 20, 18, 36, 6, 396, DateTimeKind.Utc).AddTicks(5535)),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diseases_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DoctorName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DoctorSurname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PoliclinicId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 2, 20, 18, 36, 6, 396, DateTimeKind.Utc).AddTicks(7208)),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Policlinics_PoliclinicId",
                        column: x => x.PoliclinicId,
                        principalTable: "Policlinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientPoliclinic",
                columns: table => new
                {
                    PatientsId = table.Column<int>(type: "integer", nullable: false),
                    PoliclinicsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPoliclinic", x => new { x.PatientsId, x.PoliclinicsId });
                    table.ForeignKey(
                        name: "FK_PatientPoliclinic_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientPoliclinic_Policlinics_PoliclinicsId",
                        column: x => x.PoliclinicsId,
                        principalTable: "Policlinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseSymptom",
                columns: table => new
                {
                    DiseasesId = table.Column<int>(type: "integer", nullable: false),
                    SymptomsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseSymptom", x => new { x.DiseasesId, x.SymptomsId });
                    table.ForeignKey(
                        name: "FK_DiseaseSymptom_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptom_Symptoms_SymptomsId",
                        column: x => x.SymptomsId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_PatientId",
                table: "Diseases",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptom_SymptomsId",
                table: "DiseaseSymptom",
                column: "SymptomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PoliclinicId",
                table: "Doctors",
                column: "PoliclinicId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPoliclinic_PoliclinicsId",
                table: "PatientPoliclinic",
                column: "PoliclinicsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseSymptom");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "PatientPoliclinic");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropTable(
                name: "Policlinics");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}

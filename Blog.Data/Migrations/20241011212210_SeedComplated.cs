using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class SeedComplated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("7fd207c4-647e-46e6-abfe-3442275d12db"), "Yazar 1-1", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4838), null, null, false, null, null, "Makale 1-1" },
                    { new Guid("b2c4813f-3d93-4ea9-b354-54f33c15398d"), "Yazar 2-1", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4841), null, null, false, null, null, "Makale 2-1" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("cd3535c8-c295-43c8-bc6c-afe3d0e2dff6"), "Yazar", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4950), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("e65396d8-d781-473c-b145-43dc13b9280b"), "Yazar", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4941), null, null, "images/testimage2", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("9aff9475-e934-46db-9895-e5ab2b5c78fe"), new Guid("b2c4813f-3d93-4ea9-b354-54f33c15398d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Yazar-2", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4655), null, null, new Guid("cd3535c8-c295-43c8-bc6c-afe3d0e2dff6"), false, null, null, "Makale 2", 6 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("dbd73ac3-6b1b-4bad-8d15-ed43af7fa387"), new Guid("7fd207c4-647e-46e6-abfe-3442275d12db"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Yazar", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4650), null, null, new Guid("e65396d8-d781-473c-b145-43dc13b9280b"), false, null, null, "Makale 1", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9aff9475-e934-46db-9895-e5ab2b5c78fe"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dbd73ac3-6b1b-4bad-8d15-ed43af7fa387"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fd207c4-647e-46e6-abfe-3442275d12db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2c4813f-3d93-4ea9-b354-54f33c15398d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd3535c8-c295-43c8-bc6c-afe3d0e2dff6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e65396d8-d781-473c-b145-43dc13b9280b"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

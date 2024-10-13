using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DALExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9aff9475-e934-46db-9895-e5ab2b5c78fe"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dbd73ac3-6b1b-4bad-8d15-ed43af7fa387"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("c64b1318-b583-4f3c-a1a7-1a0d73a28a4c"), new Guid("7fd207c4-647e-46e6-abfe-3442275d12db"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Yazar", new DateTime(2024, 10, 13, 21, 48, 52, 376, DateTimeKind.Local).AddTicks(8336), null, null, new Guid("e65396d8-d781-473c-b145-43dc13b9280b"), false, null, null, "Makale 1", 6 },
                    { new Guid("d981deb5-f1e4-4d5a-95c6-da0d9663fcd1"), new Guid("b2c4813f-3d93-4ea9-b354-54f33c15398d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Yazar-2", new DateTime(2024, 10, 13, 21, 48, 52, 376, DateTimeKind.Local).AddTicks(8346), null, null, new Guid("cd3535c8-c295-43c8-bc6c-afe3d0e2dff6"), false, null, null, "Makale 2", 6 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fd207c4-647e-46e6-abfe-3442275d12db"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 21, 48, 52, 376, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2c4813f-3d93-4ea9-b354-54f33c15398d"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 21, 48, 52, 376, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd3535c8-c295-43c8-bc6c-afe3d0e2dff6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 21, 48, 52, 376, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e65396d8-d781-473c-b145-43dc13b9280b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 21, 48, 52, 376, DateTimeKind.Local).AddTicks(9012));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c64b1318-b583-4f3c-a1a7-1a0d73a28a4c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d981deb5-f1e4-4d5a-95c6-da0d9663fcd1"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("9aff9475-e934-46db-9895-e5ab2b5c78fe"), new Guid("b2c4813f-3d93-4ea9-b354-54f33c15398d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Yazar-2", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4655), null, null, new Guid("cd3535c8-c295-43c8-bc6c-afe3d0e2dff6"), false, null, null, "Makale 2", 6 },
                    { new Guid("dbd73ac3-6b1b-4bad-8d15-ed43af7fa387"), new Guid("7fd207c4-647e-46e6-abfe-3442275d12db"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Yazar", new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4650), null, null, new Guid("e65396d8-d781-473c-b145-43dc13b9280b"), false, null, null, "Makale 1", 6 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fd207c4-647e-46e6-abfe-3442275d12db"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2c4813f-3d93-4ea9-b354-54f33c15398d"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd3535c8-c295-43c8-bc6c-afe3d0e2dff6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e65396d8-d781-473c-b145-43dc13b9280b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 0, 22, 10, 572, DateTimeKind.Local).AddTicks(4941));
        }
    }
}

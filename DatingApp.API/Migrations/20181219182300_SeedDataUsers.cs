using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class SeedDataUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, "Hamilton", "Finland", new DateTime(2017, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", @"Veniam ex id elit et id. Ullamco proident laborum irure fugiat laborum enim exercitation reprehenderit proident tempor dolor. Sit do consectetur amet tempor eu exercitation labore in reprehenderit laborum. Tempor velit laborum qui deserunt dolore proident amet laboris pariatur aliqua. Excepteur mollit elit esse ut laborum ad ut nisi anim. Reprehenderit amet id tempor adipisicing occaecat Lorem pariatur nisi non consequat id duis nisi. Pariatur non dolor magna cupidatat duis elit quis.
", "Freda", new DateTime(2017, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 212, 99, 213, 172, 245, 170, 179, 129, 151, 247, 249, 255, 151, 201, 228, 76, 50, 33, 223, 205, 115, 250, 170, 83, 179, 28, 132, 247, 217, 214, 0, 215, 29, 106, 155, 137, 0, 2, 92, 30, 105, 96, 252, 67, 66, 76, 55, 73, 87, 243, 132, 151, 14, 108, 225, 89, 247, 122, 77, 216, 46, 78, 238, 206 }, new byte[] { 124, 108, 240, 183, 157, 156, 112, 52, 13, 206, 158, 38, 202, 159, 106, 58, 196, 194, 48, 27, 188, 143, 168, 61, 56, 109, 87, 106, 221, 48, 33, 124, 78, 211, 248, 132, 189, 83, 86, 42, 44, 57, 22, 243, 132, 33, 118, 116, 156, 179, 108, 148, 143, 70, 29, 39, 239, 88, 73, 229, 220, 239, 116, 43, 184, 248, 45, 211, 26, 32, 228, 70, 100, 197, 101, 191, 215, 195, 8, 59, 162, 175, 162, 156, 1, 35, 214, 4, 241, 152, 168, 31, 125, 179, 158, 91, 254, 93, 45, 64, 17, 162, 234, 212, 75, 32, 69, 56, 177, 43, 42, 135, 47, 155, 181, 72, 204, 73, 144, 102, 233, 148, 60, 239, 117, 105, 14, 168 }, "freda" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, "Ypsilanti", "Latvia", new DateTime(2017, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", @"Ea eu enim mollit deserunt mollit velit Lorem. Qui ea reprehenderit consequat nulla. Velit elit proident reprehenderit officia ut eu. Ullamco consequat amet ipsum proident voluptate. Magna irure aliqua nulla cupidatat laborum aute tempor consequat. Minim amet in dolor enim velit qui. Ut ad est fugiat nostrud qui cupidatat.
", "Aida", new DateTime(2017, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 175, 206, 54, 145, 201, 113, 145, 108, 177, 23, 255, 11, 126, 221, 243, 51, 3, 249, 75, 141, 112, 220, 57, 154, 60, 179, 231, 70, 159, 185, 181, 45, 226, 111, 86, 243, 237, 73, 37, 129, 11, 231, 75, 243, 195, 173, 225, 54, 63, 205, 216, 147, 145, 153, 185, 115, 105, 104, 124, 148, 143, 131, 252, 128 }, new byte[] { 227, 159, 37, 209, 197, 191, 116, 156, 95, 115, 35, 88, 200, 3, 18, 4, 229, 36, 165, 209, 162, 129, 47, 241, 52, 201, 72, 60, 136, 36, 234, 75, 99, 68, 198, 103, 237, 89, 216, 213, 214, 241, 165, 58, 138, 95, 212, 122, 27, 26, 160, 103, 54, 9, 186, 124, 103, 143, 158, 190, 77, 3, 95, 127, 86, 23, 153, 248, 58, 11, 70, 64, 205, 98, 62, 198, 142, 92, 40, 227, 168, 44, 40, 57, 29, 97, 96, 163, 61, 189, 229, 224, 167, 8, 242, 29, 2, 233, 189, 241, 57, 79, 67, 203, 153, 220, 124, 150, 183, 252, 115, 190, 151, 216, 92, 155, 244, 171, 192, 242, 74, 3, 105, 248, 196, 4, 169, 117 }, "aida" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 3, "Starks", "Greenland", new DateTime(2017, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", @"Officia ex adipisicing laboris commodo. Ullamco culpa laborum tempor consectetur adipisicing adipisicing et aliqua reprehenderit aliquip Lorem eu elit. In reprehenderit occaecat consequat excepteur fugiat nostrud. Sit commodo minim id pariatur aute labore irure quis Lorem aliqua in aute do et. Veniam nulla pariatur officia esse commodo enim labore veniam irure do.
", "Susie", new DateTime(2017, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 201, 100, 233, 196, 241, 215, 231, 91, 78, 7, 70, 244, 116, 12, 0, 87, 38, 88, 61, 100, 32, 235, 33, 173, 179, 122, 27, 206, 144, 175, 17, 249, 70, 150, 101, 28, 48, 109, 255, 140, 52, 60, 154, 186, 52, 239, 216, 240, 242, 19, 1, 223, 149, 47, 127, 23, 37, 106, 48, 215, 26, 252, 192, 144 }, new byte[] { 247, 46, 241, 146, 192, 244, 130, 212, 210, 130, 99, 203, 107, 181, 228, 251, 252, 40, 166, 197, 155, 201, 171, 191, 164, 33, 63, 57, 106, 86, 184, 150, 224, 100, 242, 109, 137, 253, 192, 109, 26, 46, 82, 230, 168, 87, 85, 217, 74, 38, 61, 12, 14, 206, 156, 129, 85, 90, 181, 32, 232, 106, 2, 206, 251, 1, 181, 3, 223, 202, 117, 129, 193, 163, 127, 246, 9, 35, 222, 19, 162, 64, 240, 184, 32, 55, 150, 121, 242, 244, 36, 0, 156, 106, 127, 87, 197, 41, 242, 228, 80, 242, 173, 229, 140, 114, 116, 133, 209, 155, 240, 73, 239, 166, 149, 186, 238, 37, 174, 36, 153, 153, 88, 212, 230, 66, 192, 43 }, "susie" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 4, "Idamay", "Jamaica", new DateTime(2017, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", @"Ipsum consectetur dolor nisi mollit velit id do voluptate irure ea nostrud exercitation excepteur mollit. Duis sunt consectetur proident ullamco ipsum excepteur consequat do duis. Proident consequat ut laborum magna aliquip. Esse culpa tempor ullamco sunt officia officia ea occaecat elit occaecat mollit consectetur in exercitation. Laborum cillum ad laboris fugiat incididunt occaecat. Dolore laborum cillum quis esse adipisicing non Lorem eu.
", "Nichole", new DateTime(2017, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 169, 47, 49, 21, 90, 97, 172, 73, 191, 130, 60, 66, 203, 78, 175, 58, 222, 125, 106, 54, 97, 161, 232, 129, 20, 227, 8, 218, 20, 76, 22, 227, 139, 27, 249, 96, 29, 254, 136, 34, 174, 159, 248, 72, 78, 150, 189, 104, 143, 241, 11, 71, 19, 153, 187, 80, 190, 71, 49, 51, 215, 116, 125, 180 }, new byte[] { 28, 42, 144, 114, 226, 193, 8, 174, 206, 74, 73, 127, 74, 193, 244, 228, 2, 134, 7, 137, 157, 29, 177, 59, 209, 105, 98, 104, 139, 231, 107, 132, 34, 187, 48, 186, 65, 61, 88, 33, 103, 175, 150, 20, 161, 114, 177, 65, 67, 55, 97, 9, 239, 0, 98, 151, 188, 128, 60, 250, 88, 131, 45, 250, 43, 15, 219, 211, 89, 140, 78, 48, 93, 118, 160, 40, 184, 65, 10, 60, 244, 166, 193, 136, 162, 126, 134, 32, 221, 11, 224, 171, 131, 19, 148, 27, 34, 114, 52, 68, 110, 176, 33, 93, 123, 61, 12, 168, 203, 169, 198, 184, 78, 180, 120, 1, 118, 248, 83, 79, 214, 42, 210, 208, 97, 107, 112, 197 }, "nichole" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 5, "Ona", "Turks and Caicos Islands", new DateTime(2017, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", @"Dolore magna ad aute elit eiusmod pariatur in. Consectetur proident sint cillum quis ad quis. Laboris adipisicing consequat minim eiusmod irure amet. Veniam et do in voluptate nulla reprehenderit in sint. Do adipisicing quis occaecat officia non. Est aute ad cillum eiusmod velit anim esse ea dolore.
", "Bridget", new DateTime(2017, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 142, 166, 78, 116, 111, 137, 56, 243, 71, 205, 240, 155, 193, 165, 51, 148, 234, 158, 173, 170, 48, 21, 153, 21, 136, 106, 253, 157, 168, 66, 132, 63, 154, 181, 187, 181, 25, 85, 76, 149, 16, 17, 151, 36, 83, 42, 244, 61, 142, 163, 123, 24, 207, 207, 163, 184, 103, 216, 212, 180, 232, 69, 138, 117 }, new byte[] { 61, 190, 117, 159, 66, 180, 122, 35, 182, 68, 127, 244, 83, 161, 93, 71, 91, 215, 140, 144, 40, 246, 63, 72, 181, 89, 117, 3, 201, 127, 6, 2, 227, 205, 73, 38, 156, 213, 221, 135, 207, 188, 4, 189, 251, 196, 24, 136, 60, 32, 142, 81, 97, 185, 196, 198, 254, 214, 200, 93, 17, 237, 144, 193, 140, 59, 20, 33, 202, 247, 201, 241, 77, 56, 91, 52, 112, 174, 183, 253, 216, 116, 132, 100, 97, 108, 218, 42, 128, 240, 209, 8, 106, 84, 102, 146, 197, 131, 122, 191, 239, 138, 119, 192, 240, 249, 245, 226, 243, 55, 216, 43, 32, 6, 217, 149, 116, 75, 19, 142, 49, 6, 107, 237, 96, 49, 176, 54 }, "bridget" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 6, "Bennett", "Dominican Republic", new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", @"Ex sit do magna amet dolor aliquip veniam qui cillum fugiat dolore. Reprehenderit et non ipsum id non aute enim exercitation fugiat dolor fugiat eiusmod. Culpa consectetur sunt sit labore. Veniam ullamco ut cillum sit labore cupidatat consectetur dolor Lorem. Nisi nulla commodo minim aliquip aliqua anim eu eiusmod ex et nulla est ullamco. Et enim consequat fugiat consequat id id deserunt veniam aliqua nostrud nostrud.
", "Fisher", new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 138, 56, 47, 162, 168, 17, 159, 188, 218, 79, 160, 245, 219, 100, 101, 27, 184, 39, 221, 225, 168, 170, 141, 181, 119, 148, 83, 251, 189, 226, 61, 103, 72, 247, 55, 204, 191, 70, 20, 134, 210, 157, 177, 112, 103, 51, 170, 200, 250, 230, 23, 71, 237, 205, 155, 128, 7, 77, 99, 231, 22, 231, 211, 194 }, new byte[] { 158, 224, 158, 200, 250, 115, 2, 216, 207, 128, 41, 163, 199, 216, 223, 158, 79, 102, 159, 129, 161, 61, 225, 201, 230, 237, 96, 231, 74, 23, 16, 61, 52, 222, 33, 154, 95, 172, 29, 154, 84, 128, 83, 99, 27, 130, 171, 202, 249, 157, 249, 126, 73, 57, 47, 47, 167, 161, 107, 210, 66, 231, 75, 141, 245, 239, 146, 139, 80, 148, 12, 44, 174, 121, 2, 13, 81, 207, 85, 148, 107, 166, 219, 125, 66, 218, 249, 36, 255, 104, 100, 128, 80, 89, 74, 127, 31, 132, 208, 173, 100, 48, 181, 164, 132, 94, 71, 14, 28, 192, 229, 54, 219, 109, 42, 6, 133, 159, 110, 74, 131, 111, 30, 77, 0, 238, 75, 118 }, "fisher" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 7, "Chamizal", "Guadeloupe", new DateTime(2017, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", @"Esse sunt esse cupidatat enim nulla et nisi labore commodo dolor dolore laboris non. Id non Lorem cillum exercitation aliquip ut tempor. Deserunt commodo laborum proident reprehenderit eiusmod pariatur incididunt. Sit officia cupidatat adipisicing esse sunt cupidatat amet irure occaecat do est. Lorem officia magna culpa ex sit in veniam proident.
", "Simon", new DateTime(2017, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 125, 75, 255, 181, 216, 31, 63, 74, 132, 156, 85, 98, 208, 221, 199, 14, 96, 83, 221, 129, 67, 45, 61, 230, 24, 89, 175, 173, 235, 115, 243, 1, 86, 139, 123, 199, 255, 121, 28, 235, 12, 23, 8, 0, 131, 141, 164, 109, 72, 241, 124, 182, 12, 186, 151, 87, 41, 40, 242, 61, 104, 33, 120, 88 }, new byte[] { 83, 4, 174, 41, 36, 99, 210, 208, 58, 6, 94, 203, 109, 235, 240, 237, 85, 20, 107, 126, 212, 255, 81, 95, 34, 157, 89, 89, 160, 15, 99, 220, 210, 135, 215, 108, 241, 66, 181, 118, 227, 121, 15, 164, 130, 95, 38, 0, 56, 118, 69, 170, 249, 49, 112, 136, 189, 178, 211, 120, 66, 52, 253, 9, 45, 58, 34, 175, 168, 123, 123, 49, 17, 85, 32, 138, 200, 176, 15, 164, 99, 248, 32, 188, 106, 181, 85, 51, 158, 188, 156, 156, 163, 243, 239, 120, 140, 39, 191, 229, 172, 203, 248, 112, 221, 207, 44, 126, 5, 165, 55, 248, 245, 226, 118, 3, 59, 170, 245, 247, 94, 31, 237, 229, 174, 174, 78, 172 }, "simon" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 8, "Rockbridge", "Taiwan", new DateTime(2017, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", @"Anim incididunt eu eiusmod ut excepteur esse quis deserunt adipisicing enim ut culpa. Eiusmod dolor proident dolor pariatur enim do. Duis dolor cupidatat aute minim consectetur voluptate esse labore.
", "Rivers", new DateTime(2017, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 189, 92, 9, 111, 60, 48, 78, 99, 141, 128, 84, 239, 201, 224, 34, 72, 12, 240, 69, 219, 123, 128, 144, 154, 83, 96, 167, 23, 205, 244, 82, 26, 112, 55, 18, 54, 52, 63, 75, 2, 48, 190, 212, 190, 165, 185, 224, 6, 123, 188, 23, 238, 182, 98, 43, 114, 111, 189, 97, 27, 216, 127, 200, 217 }, new byte[] { 97, 69, 202, 18, 95, 64, 48, 129, 122, 251, 216, 45, 78, 78, 95, 244, 34, 35, 71, 54, 219, 11, 231, 126, 141, 2, 1, 184, 36, 235, 129, 109, 42, 201, 12, 120, 136, 187, 73, 158, 87, 243, 121, 109, 48, 203, 201, 52, 235, 131, 154, 87, 182, 109, 217, 226, 161, 172, 75, 38, 62, 238, 225, 59, 212, 233, 189, 24, 12, 34, 213, 204, 231, 33, 72, 202, 18, 125, 4, 147, 114, 167, 238, 225, 241, 105, 39, 97, 132, 166, 22, 12, 117, 81, 82, 16, 165, 73, 30, 54, 60, 60, 83, 49, 80, 236, 114, 186, 7, 42, 141, 254, 224, 82, 250, 59, 112, 6, 40, 71, 37, 54, 147, 171, 245, 133, 212, 57 }, "rivers" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 9, "Katonah", "Georgia", new DateTime(2017, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", @"In ex in incididunt esse aute sit ex anim dolore laborum nisi id ea. Consequat incididunt aute eiusmod amet ut. Esse ullamco qui anim sit adipisicing ea consectetur adipisicing sunt est duis. Esse Lorem mollit est aute quis aliquip exercitation labore voluptate. Id aute elit est Lorem.
", "Boyer", new DateTime(2017, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 213, 163, 101, 130, 161, 220, 98, 189, 31, 139, 35, 21, 215, 31, 180, 248, 72, 221, 253, 163, 24, 150, 115, 13, 148, 211, 195, 69, 77, 231, 229, 62, 89, 244, 93, 168, 13, 6, 229, 92, 83, 91, 30, 52, 219, 188, 123, 67, 250, 198, 209, 6, 93, 222, 253, 206, 52, 209, 135, 115, 96, 5, 19, 104 }, new byte[] { 221, 247, 174, 242, 227, 192, 207, 137, 136, 146, 34, 52, 152, 103, 52, 204, 178, 157, 73, 158, 246, 141, 40, 212, 132, 198, 243, 241, 147, 199, 236, 89, 38, 213, 28, 12, 139, 1, 224, 10, 185, 174, 132, 132, 65, 1, 98, 86, 238, 140, 22, 70, 216, 122, 116, 39, 206, 40, 243, 89, 149, 15, 50, 79, 9, 52, 76, 171, 199, 242, 125, 61, 147, 252, 130, 159, 108, 88, 140, 53, 227, 42, 216, 43, 133, 188, 11, 124, 238, 7, 238, 211, 233, 113, 57, 192, 116, 210, 145, 88, 135, 164, 134, 95, 141, 140, 79, 221, 156, 6, 192, 24, 46, 50, 74, 163, 23, 194, 133, 244, 107, 64, 85, 43, 233, 117, 168, 113 }, "boyer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Introduction", "KnownAs", "LastActive", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 10, "Barronett", "Botswana", new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", @"Occaecat veniam quis culpa minim ullamco sunt sint veniam elit ad magna. Sit est quis duis commodo tempor mollit duis incididunt sint. Incididunt exercitation fugiat elit Lorem culpa elit.
", "Johnson", new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 188, 118, 211, 59, 172, 212, 79, 142, 27, 219, 247, 190, 56, 158, 135, 24, 80, 1, 249, 39, 83, 47, 116, 60, 244, 186, 29, 130, 22, 122, 12, 126, 173, 67, 55, 209, 220, 69, 109, 213, 147, 232, 65, 62, 75, 196, 72, 61, 40, 237, 57, 220, 179, 106, 171, 98, 117, 213, 23, 185, 67, 179, 231, 172 }, new byte[] { 52, 68, 40, 68, 240, 228, 26, 106, 248, 152, 42, 27, 225, 64, 58, 72, 48, 87, 113, 63, 97, 201, 72, 87, 15, 164, 178, 152, 115, 83, 150, 134, 233, 12, 80, 111, 61, 241, 55, 84, 18, 93, 219, 102, 119, 78, 219, 3, 74, 219, 206, 153, 46, 197, 181, 170, 141, 231, 26, 13, 47, 219, 132, 63, 182, 159, 149, 155, 230, 24, 76, 165, 43, 196, 112, 97, 194, 211, 213, 7, 142, 216, 250, 244, 37, 25, 222, 193, 122, 104, 160, 12, 87, 166, 68, 188, 124, 255, 59, 196, 186, 233, 209, 148, 249, 63, 208, 213, 42, 211, 13, 98, 62, 31, 11, 233, 130, 10, 125, 87, 186, 203, 86, 227, 73, 90, 196, 202 }, "johnson" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut dolore minim ipsum minim exercitation anim aliqua esse.", true, "https://randomuser.me/api/portraits/women/47.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa sint consectetur in deserunt occaecat nostrud in commodo ad deserunt in minim.", true, "https://randomuser.me/api/portraits/women/33.jpg", 2 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esse aliquip enim nisi culpa sunt.", true, "https://randomuser.me/api/portraits/women/65.jpg", 3 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisicing consequat consequat sit aute officia commodo officia esse dolore dolore anim consequat nisi excepteur.", true, "https://randomuser.me/api/portraits/women/38.jpg", 4 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proident reprehenderit est enim proident ad exercitation irure eu laboris exercitation aute voluptate dolore adipisicing.", true, "https://randomuser.me/api/portraits/women/6.jpg", 5 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa commodo proident do dolor cillum pariatur eiusmod cillum reprehenderit do Lorem nulla do.", true, "https://randomuser.me/api/portraits/men/44.jpg", 6 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magna ea dolore eu incididunt eu commodo culpa sunt magna in magna est.", true, "https://randomuser.me/api/portraits/men/72.jpg", 7 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duis esse irure nulla ullamco est id consequat Lorem.", true, "https://randomuser.me/api/portraits/men/23.jpg", 8 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint aliqua ut culpa ipsum deserunt elit anim voluptate fugiat.", true, "https://randomuser.me/api/portraits/men/36.jpg", 9 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateAdded", "Description", "IsMain", "Url", "UserId" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laboris magna mollit consequat deserunt consectetur culpa commodo anim est ea sunt.", true, "https://randomuser.me/api/portraits/men/52.jpg", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

﻿// <auto-generated />
using System;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190127194330_ExtendUsersAgain2")]
    partial class ExtendUsersAgain2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<string>("Url");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");

                    b.HasData(
                        new { Id = 1, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Ut dolore minim ipsum minim exercitation anim aliqua esse.", IsMain = true, Url = "https://randomuser.me/api/portraits/women/47.jpg", UserId = 1 },
                        new { Id = 2, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Culpa sint consectetur in deserunt occaecat nostrud in commodo ad deserunt in minim.", IsMain = true, Url = "https://randomuser.me/api/portraits/women/33.jpg", UserId = 2 },
                        new { Id = 3, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Esse aliquip enim nisi culpa sunt.", IsMain = true, Url = "https://randomuser.me/api/portraits/women/65.jpg", UserId = 3 },
                        new { Id = 4, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Adipisicing consequat consequat sit aute officia commodo officia esse dolore dolore anim consequat nisi excepteur.", IsMain = true, Url = "https://randomuser.me/api/portraits/women/38.jpg", UserId = 4 },
                        new { Id = 5, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Proident reprehenderit est enim proident ad exercitation irure eu laboris exercitation aute voluptate dolore adipisicing.", IsMain = true, Url = "https://randomuser.me/api/portraits/women/6.jpg", UserId = 5 },
                        new { Id = 6, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Culpa commodo proident do dolor cillum pariatur eiusmod cillum reprehenderit do Lorem nulla do.", IsMain = true, Url = "https://randomuser.me/api/portraits/men/44.jpg", UserId = 6 },
                        new { Id = 7, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Magna ea dolore eu incididunt eu commodo culpa sunt magna in magna est.", IsMain = true, Url = "https://randomuser.me/api/portraits/men/72.jpg", UserId = 7 },
                        new { Id = 8, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Duis esse irure nulla ullamco est id consequat Lorem.", IsMain = true, Url = "https://randomuser.me/api/portraits/men/23.jpg", UserId = 8 },
                        new { Id = 9, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Sint aliqua ut culpa ipsum deserunt elit anim voluptate fugiat.", IsMain = true, Url = "https://randomuser.me/api/portraits/men/36.jpg", UserId = 9 },
                        new { Id = 10, DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Laboris magna mollit consequat deserunt consectetur culpa commodo anim est ea sunt.", IsMain = true, Url = "https://randomuser.me/api/portraits/men/52.jpg", UserId = 10 }
                    );
                });

            modelBuilder.Entity("DatingApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Gender");

                    b.Property<string>("Interested");

                    b.Property<string>("Introduction");

                    b.Property<string>("KnownAs");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("LookingFor");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, City = "Hamilton", Country = "Finland", Created = new DateTime(2017, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1980, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "female", Introduction = @"Veniam ex id elit et id. Ullamco proident laborum irure fugiat laborum enim exercitation reprehenderit proident tempor dolor. Sit do consectetur amet tempor eu exercitation labore in reprehenderit laborum. Tempor velit laborum qui deserunt dolore proident amet laboris pariatur aliqua. Excepteur mollit elit esse ut laborum ad ut nisi anim. Reprehenderit amet id tempor adipisicing occaecat Lorem pariatur nisi non consequat id duis nisi. Pariatur non dolor magna cupidatat duis elit quis.
", KnownAs = "Freda", LastActive = new DateTime(2017, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Eiusmod consequat nulla nulla cupidatat adipisicing commodo ullamco reprehenderit fugiat ad labore. Nulla commodo minim sint non consectetur deserunt do veniam aliqua amet consectetur et reprehenderit. Dolor dolor eu reprehenderit ex laborum magna adipisicing ad nisi laborum velit.
", PasswordHash = new byte[] { 91, 11, 157, 252, 25, 204, 194, 51, 207, 38, 1, 41, 201, 69, 66, 158, 108, 163, 231, 124, 202, 250, 63, 227, 57, 42, 44, 170, 229, 196, 240, 88, 202, 42, 159, 10, 4, 25, 184, 60, 237, 125, 59, 69, 151, 8, 113, 18, 82, 161, 197, 11, 61, 114, 128, 37, 6, 76, 19, 97, 22, 201, 123, 227 }, PasswordSalt = new byte[] { 202, 121, 231, 167, 189, 119, 96, 201, 37, 136, 14, 39, 185, 139, 158, 251, 41, 38, 1, 245, 180, 14, 48, 98, 197, 137, 183, 24, 208, 143, 32, 164, 158, 123, 193, 189, 212, 26, 231, 30, 8, 164, 162, 69, 41, 30, 11, 52, 236, 107, 54, 76, 66, 226, 11, 216, 218, 107, 185, 93, 14, 162, 161, 30, 157, 107, 140, 169, 55, 252, 200, 220, 72, 159, 150, 242, 173, 6, 224, 237, 108, 25, 143, 110, 117, 31, 225, 151, 95, 141, 78, 107, 52, 193, 233, 136, 36, 191, 60, 195, 118, 194, 66, 49, 26, 10, 162, 63, 169, 247, 120, 175, 100, 94, 222, 122, 209, 237, 11, 90, 6, 103, 18, 154, 82, 201, 46, 165 }, Username = "freda" },
                        new { Id = 2, City = "Ypsilanti", Country = "Latvia", Created = new DateTime(2017, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1989, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "female", Introduction = @"Ea eu enim mollit deserunt mollit velit Lorem. Qui ea reprehenderit consequat nulla. Velit elit proident reprehenderit officia ut eu. Ullamco consequat amet ipsum proident voluptate. Magna irure aliqua nulla cupidatat laborum aute tempor consequat. Minim amet in dolor enim velit qui. Ut ad est fugiat nostrud qui cupidatat.
", KnownAs = "Aida", LastActive = new DateTime(2017, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Est ad do cillum anim exercitation pariatur ea pariatur aliqua duis consectetur ut ullamco veniam. Eu ea et ipsum amet pariatur dolor nostrud sunt tempor ipsum veniam fugiat proident. In aliquip laboris fugiat anim duis. Proident exercitation exercitation cillum aliquip aliquip ullamco nostrud magna enim. Ea Lorem aute et consequat nulla ullamco aliqua proident magna aliquip nulla. Voluptate officia ex sit tempor eiusmod qui nulla eiusmod sit. Consectetur duis pariatur dolore anim ut ad cupidatat proident incididunt excepteur ad.
", PasswordHash = new byte[] { 9, 222, 201, 225, 46, 202, 60, 240, 108, 209, 75, 211, 72, 68, 32, 58, 152, 30, 118, 56, 217, 158, 255, 16, 207, 33, 84, 243, 27, 87, 124, 89, 0, 62, 130, 239, 232, 155, 34, 193, 246, 122, 131, 164, 224, 134, 20, 7, 126, 47, 63, 219, 141, 137, 66, 74, 206, 25, 134, 92, 111, 226, 89, 216 }, PasswordSalt = new byte[] { 116, 52, 36, 152, 138, 148, 78, 129, 253, 203, 249, 107, 178, 238, 55, 230, 41, 81, 89, 240, 222, 145, 47, 210, 184, 111, 17, 116, 247, 146, 176, 19, 57, 246, 160, 203, 20, 98, 25, 83, 141, 47, 81, 207, 86, 88, 44, 136, 114, 208, 175, 8, 255, 150, 123, 73, 184, 174, 227, 56, 152, 240, 48, 236, 147, 167, 11, 152, 210, 184, 174, 9, 250, 226, 226, 120, 223, 103, 246, 75, 4, 125, 250, 124, 173, 163, 164, 28, 7, 44, 53, 71, 24, 5, 118, 184, 223, 223, 130, 223, 135, 207, 95, 19, 246, 132, 134, 75, 83, 95, 223, 247, 183, 140, 23, 153, 31, 247, 26, 18, 242, 41, 83, 234, 166, 111, 246, 175 }, Username = "aida" },
                        new { Id = 3, City = "Starks", Country = "Greenland", Created = new DateTime(2017, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1972, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "female", Introduction = @"Officia ex adipisicing laboris commodo. Ullamco culpa laborum tempor consectetur adipisicing adipisicing et aliqua reprehenderit aliquip Lorem eu elit. In reprehenderit occaecat consequat excepteur fugiat nostrud. Sit commodo minim id pariatur aute labore irure quis Lorem aliqua in aute do et. Veniam nulla pariatur officia esse commodo enim labore veniam irure do.
", KnownAs = "Susie", LastActive = new DateTime(2017, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Pariatur consequat enim ad ex fugiat ex aliquip anim quis sit laborum ex. Anim ex ut enim velit minim enim labore et veniam ea voluptate. Ad amet dolore et laborum ad cillum id ad non sint do non non nisi. Excepteur labore labore ea ut aliqua qui magna nulla.
", PasswordHash = new byte[] { 46, 165, 185, 63, 1, 249, 139, 167, 213, 127, 176, 194, 236, 144, 72, 17, 209, 123, 134, 49, 181, 197, 88, 170, 173, 6, 182, 248, 214, 117, 4, 26, 74, 48, 252, 8, 46, 101, 212, 120, 205, 170, 51, 189, 126, 56, 110, 124, 254, 193, 213, 238, 43, 28, 35, 136, 230, 32, 25, 184, 246, 98, 187, 67 }, PasswordSalt = new byte[] { 51, 152, 50, 134, 226, 48, 129, 116, 35, 252, 126, 107, 141, 92, 91, 174, 213, 202, 52, 115, 164, 221, 31, 228, 110, 239, 193, 133, 165, 56, 131, 180, 221, 54, 57, 106, 142, 31, 119, 151, 180, 14, 155, 181, 199, 193, 179, 119, 208, 60, 252, 38, 144, 83, 211, 153, 212, 166, 228, 251, 17, 49, 234, 41, 238, 108, 3, 150, 223, 48, 207, 68, 82, 17, 212, 163, 181, 106, 190, 16, 229, 123, 152, 250, 146, 121, 183, 188, 69, 196, 182, 228, 64, 203, 202, 6, 205, 146, 137, 250, 171, 70, 125, 244, 187, 175, 63, 253, 51, 235, 29, 8, 164, 149, 59, 197, 250, 67, 153, 9, 252, 230, 191, 66, 192, 144, 118, 197 }, Username = "susie" },
                        new { Id = 4, City = "Idamay", Country = "Jamaica", Created = new DateTime(2017, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1968, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "female", Introduction = @"Ipsum consectetur dolor nisi mollit velit id do voluptate irure ea nostrud exercitation excepteur mollit. Duis sunt consectetur proident ullamco ipsum excepteur consequat do duis. Proident consequat ut laborum magna aliquip. Esse culpa tempor ullamco sunt officia officia ea occaecat elit occaecat mollit consectetur in exercitation. Laborum cillum ad laboris fugiat incididunt occaecat. Dolore laborum cillum quis esse adipisicing non Lorem eu.
", KnownAs = "Nichole", LastActive = new DateTime(2017, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Cupidatat cillum laborum labore esse cillum culpa irure quis ad eiusmod quis nulla. Dolor nulla deserunt laborum officia consectetur officia sunt labore quis labore consectetur aute. Qui irure labore dolore in irure consequat exercitation elit proident eiusmod fugiat do. In est irure commodo ad cillum ut id cillum sit cupidatat elit. Consectetur cillum exercitation voluptate aliqua proident adipisicing ex. Officia qui est eiusmod commodo aliqua et.
", PasswordHash = new byte[] { 38, 135, 141, 66, 236, 100, 6, 212, 113, 216, 210, 252, 91, 208, 206, 16, 104, 243, 220, 191, 215, 195, 45, 210, 10, 183, 27, 195, 108, 75, 116, 97, 136, 147, 215, 242, 231, 157, 53, 158, 219, 39, 152, 205, 0, 123, 242, 24, 28, 58, 155, 92, 237, 49, 104, 84, 243, 202, 248, 68, 254, 230, 103, 110 }, PasswordSalt = new byte[] { 6, 151, 63, 57, 75, 12, 162, 50, 174, 176, 74, 81, 29, 224, 174, 219, 57, 173, 116, 118, 196, 104, 86, 139, 18, 47, 188, 200, 46, 65, 108, 123, 189, 98, 136, 184, 252, 254, 60, 128, 13, 62, 210, 229, 145, 214, 171, 117, 167, 227, 57, 169, 163, 216, 191, 218, 134, 216, 181, 234, 165, 246, 34, 45, 233, 137, 64, 102, 213, 248, 168, 23, 214, 52, 96, 78, 51, 24, 165, 127, 246, 73, 78, 228, 165, 60, 84, 28, 106, 171, 157, 86, 14, 247, 210, 223, 32, 210, 193, 195, 10, 8, 238, 4, 56, 132, 129, 187, 130, 106, 144, 170, 225, 153, 172, 93, 220, 109, 81, 55, 153, 149, 101, 88, 45, 28, 180, 17 }, Username = "nichole" },
                        new { Id = 5, City = "Ona", Country = "Turks and Caicos Islands", Created = new DateTime(2017, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "female", Introduction = @"Dolore magna ad aute elit eiusmod pariatur in. Consectetur proident sint cillum quis ad quis. Laboris adipisicing consequat minim eiusmod irure amet. Veniam et do in voluptate nulla reprehenderit in sint. Do adipisicing quis occaecat officia non. Est aute ad cillum eiusmod velit anim esse ea dolore.
", KnownAs = "Bridget", LastActive = new DateTime(2017, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Reprehenderit amet id elit elit enim veniam sint esse deserunt. Consectetur sit qui reprehenderit in nulla anim laboris ea. Et ad ad pariatur adipisicing enim dolor. Exercitation mollit dolore incididunt irure dolore mollit enim do qui elit. Tempor dolore consequat veniam culpa commodo amet non excepteur consequat deserunt dolore.
", PasswordHash = new byte[] { 50, 11, 160, 242, 144, 12, 102, 159, 166, 137, 139, 205, 159, 50, 75, 121, 101, 34, 126, 120, 119, 243, 193, 60, 204, 158, 224, 226, 120, 71, 118, 56, 75, 96, 25, 58, 104, 45, 59, 78, 229, 62, 49, 144, 144, 187, 170, 125, 59, 88, 212, 22, 17, 228, 230, 174, 111, 250, 37, 163, 178, 54, 181, 113 }, PasswordSalt = new byte[] { 79, 231, 31, 163, 200, 55, 205, 163, 127, 229, 93, 136, 38, 40, 23, 244, 178, 139, 75, 184, 167, 122, 62, 50, 7, 48, 34, 122, 78, 36, 223, 54, 156, 65, 59, 63, 104, 87, 125, 229, 42, 234, 94, 29, 60, 61, 34, 200, 76, 237, 117, 158, 253, 64, 137, 13, 9, 178, 33, 168, 188, 158, 85, 228, 150, 203, 44, 75, 162, 229, 28, 178, 124, 213, 4, 69, 214, 149, 36, 113, 90, 56, 37, 24, 121, 164, 76, 149, 84, 86, 37, 77, 51, 101, 124, 50, 44, 118, 240, 125, 64, 22, 182, 184, 112, 143, 172, 238, 58, 142, 77, 82, 137, 101, 104, 73, 77, 44, 111, 177, 18, 94, 180, 133, 130, 63, 123, 30 }, Username = "bridget" },
                        new { Id = 6, City = "Bennett", Country = "Dominican Republic", Created = new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1990, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "male", Introduction = @"Ex sit do magna amet dolor aliquip veniam qui cillum fugiat dolore. Reprehenderit et non ipsum id non aute enim exercitation fugiat dolor fugiat eiusmod. Culpa consectetur sunt sit labore. Veniam ullamco ut cillum sit labore cupidatat consectetur dolor Lorem. Nisi nulla commodo minim aliquip aliqua anim eu eiusmod ex et nulla est ullamco. Et enim consequat fugiat consequat id id deserunt veniam aliqua nostrud nostrud.
", KnownAs = "Fisher", LastActive = new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Pariatur qui nostrud eu excepteur aliquip aliquip non. Ipsum eu commodo cillum minim labore elit sint velit laboris mollit fugiat minim tempor. Consequat ex consequat sunt officia. Anim exercitation do dolore ut do excepteur eu duis ut voluptate dolor eiusmod aute. Amet veniam ad in mollit duis magna esse eu amet nulla elit non elit ea. Officia excepteur et commodo cupidatat amet non aliqua laborum consectetur nisi nostrud anim adipisicing. Sint non duis ex amet voluptate ex.
", PasswordHash = new byte[] { 117, 93, 160, 127, 65, 56, 237, 24, 212, 106, 152, 81, 169, 80, 4, 149, 132, 118, 102, 0, 249, 13, 110, 166, 96, 235, 202, 233, 100, 250, 192, 231, 108, 254, 129, 33, 21, 9, 98, 213, 124, 77, 233, 34, 232, 168, 65, 214, 18, 197, 231, 25, 5, 43, 8, 11, 182, 139, 68, 190, 255, 199, 205, 134 }, PasswordSalt = new byte[] { 204, 229, 181, 201, 10, 201, 246, 71, 16, 27, 126, 119, 232, 155, 172, 59, 154, 182, 92, 250, 182, 170, 152, 89, 84, 69, 246, 202, 38, 238, 156, 8, 243, 183, 47, 112, 150, 169, 66, 173, 137, 241, 156, 169, 118, 196, 205, 89, 236, 197, 244, 88, 157, 146, 89, 234, 29, 159, 254, 73, 249, 13, 94, 149, 103, 238, 254, 238, 22, 34, 115, 251, 90, 36, 219, 179, 17, 98, 105, 35, 87, 193, 164, 53, 11, 71, 140, 63, 173, 75, 205, 58, 17, 149, 159, 190, 129, 233, 33, 235, 177, 158, 162, 225, 155, 152, 189, 219, 105, 221, 11, 128, 125, 10, 236, 228, 212, 115, 19, 240, 245, 164, 18, 80, 89, 114, 218, 229 }, Username = "fisher" },
                        new { Id = 7, City = "Chamizal", Country = "Guadeloupe", Created = new DateTime(2017, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1964, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "male", Introduction = @"Esse sunt esse cupidatat enim nulla et nisi labore commodo dolor dolore laboris non. Id non Lorem cillum exercitation aliquip ut tempor. Deserunt commodo laborum proident reprehenderit eiusmod pariatur incididunt. Sit officia cupidatat adipisicing esse sunt cupidatat amet irure occaecat do est. Lorem officia magna culpa ex sit in veniam proident.
", KnownAs = "Simon", LastActive = new DateTime(2017, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Ullamco ad elit ex ullamco consectetur sint laborum occaecat. Qui sunt aute est culpa irure incididunt culpa sunt et in. Aute esse id ex commodo elit. Exercitation cupidatat laboris officia elit aliquip exercitation aliqua. Sunt sit ea ea sint consequat consectetur eu proident aliquip anim veniam. Ipsum esse do reprehenderit sint veniam dolore proident dolor do. Cupidatat laborum sunt enim voluptate in laboris ipsum ea laborum in eu.
", PasswordHash = new byte[] { 31, 54, 128, 21, 191, 220, 113, 16, 21, 170, 72, 37, 160, 55, 2, 104, 14, 191, 201, 151, 158, 87, 21, 65, 184, 78, 36, 1, 155, 98, 89, 124, 78, 56, 2, 74, 169, 155, 102, 56, 4, 21, 191, 158, 250, 79, 107, 200, 252, 72, 219, 231, 176, 181, 24, 113, 38, 225, 138, 143, 56, 136, 186, 158 }, PasswordSalt = new byte[] { 122, 214, 151, 82, 243, 175, 137, 67, 240, 139, 32, 201, 19, 25, 88, 184, 2, 232, 124, 77, 44, 250, 162, 49, 187, 4, 174, 190, 123, 38, 231, 160, 184, 184, 4, 183, 133, 229, 240, 17, 35, 37, 181, 34, 145, 245, 58, 203, 182, 96, 197, 211, 8, 104, 202, 26, 19, 234, 102, 177, 80, 191, 237, 201, 183, 222, 110, 48, 229, 130, 54, 52, 247, 239, 4, 169, 155, 103, 128, 213, 245, 105, 203, 89, 40, 7, 212, 222, 33, 53, 131, 224, 15, 203, 106, 80, 130, 209, 111, 165, 115, 16, 15, 198, 223, 38, 161, 173, 150, 142, 136, 114, 191, 224, 156, 56, 76, 86, 109, 39, 226, 206, 169, 189, 47, 109, 4, 10 }, Username = "simon" },
                        new { Id = 8, City = "Rockbridge", Country = "Taiwan", Created = new DateTime(2017, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1952, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "male", Introduction = @"Anim incididunt eu eiusmod ut excepteur esse quis deserunt adipisicing enim ut culpa. Eiusmod dolor proident dolor pariatur enim do. Duis dolor cupidatat aute minim consectetur voluptate esse labore.
", KnownAs = "Rivers", LastActive = new DateTime(2017, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Deserunt amet ad duis anim non velit. Occaecat adipisicing consectetur aute commodo cillum aliquip magna laborum irure eu. Velit aliquip incididunt pariatur fugiat amet eiusmod consequat Lorem et ipsum Lorem amet.
", PasswordHash = new byte[] { 137, 182, 191, 46, 183, 113, 255, 60, 84, 81, 249, 142, 171, 19, 173, 125, 5, 231, 253, 204, 194, 223, 39, 127, 20, 89, 8, 189, 242, 45, 21, 152, 93, 56, 223, 57, 217, 255, 35, 154, 251, 124, 246, 2, 93, 122, 246, 91, 146, 44, 30, 182, 221, 19, 22, 83, 32, 101, 71, 240, 239, 76, 40, 12 }, PasswordSalt = new byte[] { 154, 192, 54, 78, 103, 236, 165, 13, 135, 33, 20, 204, 38, 220, 155, 243, 45, 159, 228, 237, 246, 85, 135, 58, 110, 250, 117, 14, 206, 195, 128, 185, 60, 238, 122, 126, 22, 204, 210, 65, 150, 145, 253, 132, 35, 204, 94, 89, 209, 0, 74, 237, 143, 55, 179, 122, 50, 114, 120, 167, 163, 133, 185, 165, 46, 186, 243, 186, 242, 46, 15, 22, 207, 82, 49, 11, 192, 190, 42, 131, 248, 168, 128, 53, 76, 82, 34, 230, 143, 168, 14, 157, 234, 221, 217, 34, 173, 54, 202, 241, 30, 34, 3, 187, 214, 86, 105, 249, 219, 65, 214, 151, 12, 142, 249, 2, 6, 179, 102, 56, 108, 245, 58, 249, 90, 168, 189, 79 }, Username = "rivers" },
                        new { Id = 9, City = "Katonah", Country = "Georgia", Created = new DateTime(2017, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1974, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "male", Introduction = @"In ex in incididunt esse aute sit ex anim dolore laborum nisi id ea. Consequat incididunt aute eiusmod amet ut. Esse ullamco qui anim sit adipisicing ea consectetur adipisicing sunt est duis. Esse Lorem mollit est aute quis aliquip exercitation labore voluptate. Id aute elit est Lorem.
", KnownAs = "Boyer", LastActive = new DateTime(2017, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Ipsum sint esse do amet minim ipsum id non nulla nostrud eiusmod deserunt. Magna Lorem deserunt aliqua aliquip aliquip tempor culpa nulla occaecat pariatur. Voluptate minim commodo sint ad commodo nostrud. Ullamco fugiat occaecat sint laboris sunt aliqua fugiat in enim. Exercitation excepteur aliqua commodo fugiat proident mollit.
", PasswordHash = new byte[] { 172, 255, 194, 160, 125, 189, 73, 182, 203, 29, 225, 14, 66, 39, 181, 79, 75, 91, 14, 172, 219, 121, 102, 64, 157, 111, 66, 186, 34, 183, 39, 160, 117, 190, 32, 118, 22, 104, 48, 249, 196, 202, 236, 147, 198, 28, 54, 234, 112, 159, 248, 137, 13, 169, 121, 191, 219, 121, 198, 111, 78, 160, 85, 0 }, PasswordSalt = new byte[] { 63, 130, 107, 112, 87, 12, 126, 165, 206, 162, 6, 244, 163, 165, 81, 179, 147, 186, 213, 169, 201, 176, 185, 67, 191, 92, 51, 224, 174, 218, 204, 88, 179, 33, 212, 97, 205, 11, 55, 32, 252, 46, 15, 184, 93, 10, 232, 230, 140, 255, 29, 178, 36, 41, 72, 80, 76, 199, 189, 0, 244, 194, 172, 241, 195, 96, 136, 70, 128, 176, 88, 141, 244, 60, 241, 73, 82, 131, 168, 36, 214, 232, 226, 39, 65, 129, 182, 248, 108, 70, 87, 33, 69, 168, 174, 21, 160, 102, 79, 190, 81, 216, 152, 24, 32, 28, 19, 60, 213, 200, 183, 118, 214, 231, 55, 70, 221, 66, 146, 8, 46, 169, 139, 72, 207, 135, 168, 139 }, Username = "boyer" },
                        new { Id = 10, City = "Barronett", Country = "Botswana", Created = new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), DateOfBirth = new DateTime(1957, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = "male", Introduction = @"Occaecat veniam quis culpa minim ullamco sunt sint veniam elit ad magna. Sit est quis duis commodo tempor mollit duis incididunt sint. Incididunt exercitation fugiat elit Lorem culpa elit.
", KnownAs = "Johnson", LastActive = new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), LookingFor = @"Anim consequat ut nostrud veniam ea ipsum duis ea nisi ullamco quis. Anim anim elit duis commodo occaecat quis quis esse. Excepteur occaecat ipsum mollit mollit amet velit occaecat fugiat nostrud. Proident anim sunt officia ex elit ea culpa est ut officia adipisicing quis. Nulla non cupidatat commodo ullamco amet voluptate elit consectetur.
", PasswordHash = new byte[] { 172, 244, 235, 215, 39, 196, 29, 149, 143, 115, 98, 98, 82, 152, 144, 238, 95, 162, 88, 83, 39, 123, 21, 38, 45, 29, 235, 225, 174, 163, 98, 215, 168, 69, 252, 158, 25, 85, 131, 77, 147, 223, 175, 207, 14, 168, 88, 8, 127, 166, 68, 189, 76, 213, 210, 5, 30, 236, 202, 178, 207, 60, 128, 209 }, PasswordSalt = new byte[] { 47, 2, 240, 192, 127, 111, 66, 44, 164, 232, 132, 165, 63, 103, 71, 97, 227, 202, 21, 203, 226, 50, 154, 100, 29, 241, 69, 109, 136, 95, 254, 146, 89, 248, 197, 6, 79, 103, 156, 140, 146, 159, 253, 205, 115, 179, 216, 224, 77, 193, 224, 91, 216, 164, 10, 91, 189, 236, 40, 8, 223, 5, 92, 107, 241, 88, 208, 234, 57, 178, 178, 121, 51, 52, 112, 72, 98, 119, 156, 210, 36, 204, 95, 150, 83, 3, 97, 201, 74, 118, 159, 111, 169, 236, 147, 116, 79, 253, 122, 134, 161, 234, 87, 87, 174, 156, 119, 181, 28, 235, 91, 24, 122, 248, 60, 162, 77, 117, 210, 123, 255, 86, 224, 212, 107, 225, 132, 99 }, Username = "johnson" }
                    );
                });

            modelBuilder.Entity("DatingApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

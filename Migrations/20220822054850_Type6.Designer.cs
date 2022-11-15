﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tmp.Models;

namespace Tmp.Migrations
{
    [DbContext(typeof(GreatChemistContext))]
    [Migration("20220822054850_Type6")]
    partial class Type6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tmp.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Tmp.Models.Iteration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.HasKey("Id");

                    b.ToTable("Iterations");
                });

            modelBuilder.Entity("Tmp.Models.QuestionType1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Btn1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuestionsType1");
                });

            modelBuilder.Entity("Tmp.Models.QuestionType2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Btn1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn3")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn4")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuestionsType2");
                });

            modelBuilder.Entity("Tmp.Models.QuestionType3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Btn1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn10")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn11")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn12")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn13")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn14")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn3")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn4")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn5")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn6")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn7")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn8")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn9")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuestionsType3");
                });

            modelBuilder.Entity("Tmp.Models.QuestionType4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Btn1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Btn3")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuestionsType4");
                });

            modelBuilder.Entity("Tmp.Models.QuestionType5", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuestionsType5");
                });

            modelBuilder.Entity("Tmp.Models.QuestionType6", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description1")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QuestionLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float?>("Right1")
                        .HasColumnType("real");

                    b.Property<float?>("Right2")
                        .HasColumnType("real");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuestionsType6");
                });

            modelBuilder.Entity("Tmp.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Tmp.Models.TaskTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TaskTimes");
                });

            modelBuilder.Entity("Tmp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInf")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("MainHand")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswerType1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserAnswersType1");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswerType2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserAnswersType2");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswerType3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserAnswersType3");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswerType4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserAnswersType4");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswerType6", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<float?>("UserAnswer1")
                        .HasColumnType("real");

                    b.Property<float?>("UserAnswer2")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("UserAnswersType6");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswersType1withRights", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToView("UserAnswersType1withRights");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswersType2withRights", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToView("UserAnswersType2withRights");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswersType3withRights", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToView("UserAnswersType3withRights");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswersType4withRights", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("RightBtn")
                        .HasColumnType("int");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToView("UserAnswersType4withRights");
                });

            modelBuilder.Entity("Tmp.Models.UserAnswersType6withRights", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IterationId")
                        .HasColumnType("int");

                    b.Property<int>("Parallel")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<float>("Right1")
                        .HasColumnType("real");

                    b.Property<float>("Right2")
                        .HasColumnType("real");

                    b.Property<int>("Task")
                        .HasColumnType("int");

                    b.Property<float>("UserAnswer1")
                        .HasColumnType("real");

                    b.Property<float>("UserAnswer2")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToView("UserAnswersType6withRights");
                });
#pragma warning restore 612, 618
        }
    }
}

namespace API_Example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Student_Id = c.Int(),
                        School_SchoolId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .ForeignKey("dbo.Schools", t => t.School_SchoolId)
                .Index(t => t.Student_Id)
                .Index(t => t.School_SchoolId);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        LessonId = c.Int(nullable: false, identity: true),
                        LessonName = c.String(),
                        School_SchoolId = c.Int(),
                        Class_ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.LessonId)
                .ForeignKey("dbo.Schools", t => t.School_SchoolId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .Index(t => t.School_SchoolId)
                .Index(t => t.Class_ClassId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        SchoolId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        Lesson_LessonId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lessons", t => t.Lesson_LessonId)
                .Index(t => t.Lesson_LessonId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        SchoolId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SchoolId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        LessonId = c.Int(nullable: false),
                        School_SchoolId = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Schools", t => t.School_SchoolId)
                .Index(t => t.School_SchoolId);
            
            CreateTable(
                "dbo.Student_",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SchoolStudents",
                c => new
                    {
                        School_SchoolId = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.School_SchoolId, t.Student_Id })
                .ForeignKey("dbo.Schools", t => t.School_SchoolId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.School_SchoolId)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.TeacherLessons",
                c => new
                    {
                        Teacher_TeacherId = c.Int(nullable: false),
                        Lesson_LessonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherId, t.Lesson_LessonId })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Lessons", t => t.Lesson_LessonId, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherId)
                .Index(t => t.Lesson_LessonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lessons", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Students", "Lesson_LessonId", "dbo.Lessons");
            DropForeignKey("dbo.Teachers", "School_SchoolId", "dbo.Schools");
            DropForeignKey("dbo.TeacherLessons", "Lesson_LessonId", "dbo.Lessons");
            DropForeignKey("dbo.TeacherLessons", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.SchoolStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.SchoolStudents", "School_SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Lessons", "School_SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Classes", "School_SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Classes", "Student_Id", "dbo.Students");
            DropIndex("dbo.TeacherLessons", new[] { "Lesson_LessonId" });
            DropIndex("dbo.TeacherLessons", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.SchoolStudents", new[] { "Student_Id" });
            DropIndex("dbo.SchoolStudents", new[] { "School_SchoolId" });
            DropIndex("dbo.Teachers", new[] { "School_SchoolId" });
            DropIndex("dbo.Students", new[] { "Lesson_LessonId" });
            DropIndex("dbo.Lessons", new[] { "Class_ClassId" });
            DropIndex("dbo.Lessons", new[] { "School_SchoolId" });
            DropIndex("dbo.Classes", new[] { "School_SchoolId" });
            DropIndex("dbo.Classes", new[] { "Student_Id" });
            DropTable("dbo.TeacherLessons");
            DropTable("dbo.SchoolStudents");
            DropTable("dbo.Student_");
            DropTable("dbo.Teachers");
            DropTable("dbo.Schools");
            DropTable("dbo.Students");
            DropTable("dbo.Lessons");
            DropTable("dbo.Classes");
        }
    }
}

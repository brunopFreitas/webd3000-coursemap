#nullable disable
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;

namespace w0448225CourseMap.Models
{
    public static class SeedData
    {        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new w0448225CourseMapContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<w0448225CourseMapContext>>()))
            {
                // Look for any diplomas.
                // If there are no diplomas in the table,
                // we'll assume that the database has not yet been seeded
                if (!context.Diplomas.Any())
                {
                    SeedTheDatabase(context);
                }
            }
        }
        
        
    	private static void SeedTheDatabase(w0448225CourseMapContext context) 
    	{

        #region SEED DIPLOMAS

                    context.Diplomas.AddRange(
                        new Diploma{ Title = "IT - Web Programming" },
                        new Diploma{ Title = "IT - Programming" },
                        new Diploma{ Title = "IT - Data Analytics" },
                        new Diploma{ Title = "IT - Database Administration" },
                        new Diploma{ Title = "IT - Systems Management & Security" },
                        new Diploma{ Title = "IT - Generalist" },
                        new Diploma{ Title = "Cyber Security" },
                        new Diploma{ Title = "Computer Electronics Technician" },
			            new Diploma{ Title = "Business Intelligence Analytics" },
						new Diploma{ Title = "Embedded Systems Programming" },
						new Diploma{ Title = "Full Stack Application Development" }
                    );
                    context.SaveChanges();

                    //GET NEWLY GENERATED DIPLOMAS FOR LATER USE
                    List<Diploma> generatedDiplomas = context.Diplomas.ToList();

        #endregion

        #region SEED ACADEMIC YEARS

                    context.AcademicYears.AddRange(
                        new AcademicYear{ Title = "2018-19" },
			            new AcademicYear{ Title = "2019-20" },
						new AcademicYear{ Title = "2020-21" },
						new AcademicYear{ Title = "2021-22" },
						new AcademicYear{ Title = "2022-23" }
                    );
                    context.SaveChanges();

                    //GET NEWLY GENERATED ACADEMIC YEARS FOR LATER USE
                    List<AcademicYear> generatedAcademicYears = context.AcademicYears.ToList();

        #endregion //SEED ACADEMIC YEARS        

        #region SEED INSTRUCTORS

                    context.Instructors.AddRange(
                        new Instructor { FirstName="Yousef",     LastName="Abu Baker" },
                        new Instructor { FirstName="Tanyia",     LastName="Arenburg" },
                        new Instructor { FirstName="Shawn",      LastName="Bigley" },
                        new Instructor { FirstName="Michael",    LastName="Caines" },
						new Instructor { FirstName="George",     LastName="Campanis" },
                        new Instructor { FirstName="Pourush",    LastName="Chowdhary" },
                        new Instructor { FirstName="Michael",    LastName="Crocker" },
                        new Instructor { FirstName="Bill",       LastName="Cunningham" },
						new Instructor { FirstName="Matt",       LastName="Dares" },
                        new Instructor { FirstName="Paul",       LastName="Drover" },
                        new Instructor { FirstName="Marcel",     LastName="D'Entremont" },
                        new Instructor { FirstName="Patrick",    LastName="Dolinger" },
                        new Instructor { FirstName="Marie",      LastName="Dutka" },
                        new Instructor { FirstName="Geoff",      LastName="Gillespie" },
						new Instructor { FirstName="Noha",       LastName="Hassan" },
						new Instructor { FirstName="Matthew",    LastName="Henshaw" },
                        new Instructor { FirstName="Pete",       LastName="Hinton" },
	                    new Instructor { FirstName="Cheolsoon",  LastName="Im" },
                        new Instructor { FirstName="Shaun",      LastName="Johansen" },
                        new Instructor { FirstName="Melodie",    LastName="Joy" },
						new Instructor { FirstName="Jaspinder",  LastName="Kaur" },
						new Instructor { FirstName="Dennis",  	 LastName="Kearney" },
						new Instructor { FirstName="Jennifer",   LastName="Kirkey" },
                        new Instructor { FirstName="Alison",     LastName="Knott" },
	                    new Instructor { FirstName="Bill",     	 LastName="Kowalski" },
						new Instructor { FirstName="Hamlet",     LastName="Lin" },
                        new Instructor { FirstName="Matthew",    LastName="McGillivary" },
                        new Instructor { FirstName="Ron",        LastName="McLeod" },
                        new Instructor { FirstName="Chris",      LastName="Mogensen" },
						new Instructor { FirstName="Peter",      LastName="Morin" },
						new Instructor { FirstName="Nick",		 LastName="Muise" },
                        new Instructor { FirstName="Hal",        LastName="O'Connell" },
                        new Instructor { FirstName="Ronan",      LastName="O'Driscoll" },
						new Instructor { FirstName="Alfred",	 LastName="Parks" },
						new Instructor { FirstName="Priya",	 	 LastName="Pathak" },
                        new Instructor { FirstName="David",      LastName="Russell" },
	                    new Instructor { FirstName="Nicole",     LastName="Sawler" },
                        new Instructor { FirstName="Marc",       LastName="Scarfone" },
                        new Instructor { FirstName="Brian",      LastName="Shewan" },
						new Instructor { FirstName="Simranjit",  LastName="Singh" },
						new Instructor { FirstName="Michael",    LastName="Smith" },
                        new Instructor { FirstName="Marsha",     LastName="South" },
                        new Instructor { FirstName="Emma",       LastName="Street" },
                        new Instructor { FirstName="Paul",       LastName="Street" },
						new Instructor { FirstName="Michael",    LastName="Trumbull" },
                        new Instructor { FirstName="Dean",       LastName="Tsaltas" },
                        new Instructor { FirstName="Anne-Marie", LastName="Verge" },
                        new Instructor { FirstName="Todd",       LastName="Verge" },
                        new Instructor { FirstName="Ken",        LastName="Warren" }
                    );
                    context.SaveChanges();

                    //GET NEWLY CREATED INSTRUCTORS FOR LATER USE
                    List<Instructor> generatedInstructors = context.Instructors.ToList();

        #endregion //SEED INSTRUCTORS

        #region SEED COURSES

                    context.Courses.AddRange(
                        new Course { CourseCode = "APPD 1001", Title = "User Interface Design & Development" },
                        new Course { CourseCode = "APPD 2000", Title = "Mobile Application Development" },
                        new Course { CourseCode = "APPD 5000", Title = "Intro to Software Development" },
                        new Course { CourseCode = "APPD 5010", Title = "Software Testing and Quality Control" },
                        new Course { CourseCode = "APPD 5015", Title = "Cross Platform Application Development" },
                        new Course { CourseCode = "CETN 1000", Title = "DC Circuits" },
                        new Course { CourseCode = "CETN 1015", Title = "Printed Circuit Board Design" },
                        new Course { CourseCode = "CETN 2005", Title = "AC Circuits" },
                        new Course { CourseCode = "CETN 2015", Title = "Semiconductors I" },
                        new Course { CourseCode = "CETN 2020", Title = "Digital Circuits I" },
                        new Course { CourseCode = "CETN 2105", Title = "Digital Circuits II" },
                        new Course { CourseCode = "CETN 2700", Title = "Introduction to Computer Aided Design and Drafting" },
                        new Course { CourseCode = "CETN 3001", Title = "Embedded Controllers" },
                        new Course { CourseCode = "CETN 3010", Title = "Programming in C" },
                        new Course { CourseCode = "CETN 3020", Title = "Project Planning" },
                        new Course { CourseCode = "CETN 3025", Title = "Semiconductors II" },
                        new Course { CourseCode = "CETN 4001", Title = "Senior Project" },
                        new Course { CourseCode = "COMM 1700", Title = "Professional Practices for IT I" },
                        new Course { CourseCode = "COMM 2700", Title = "Professional Practices for IT II" },
                        new Course { CourseCode = "COMM 3700", Title = "Professional Practices for IT III" },
                        new Course { CourseCode = "COMM 4700", Title = "Professional Practices for IT IV" },
                        new Course { CourseCode = "COMP 2000", Title = "Applied Social Media" },
                        new Course { CourseCode = "CSTN 4015", Title = "Help Desk & Customer Support" },
                        new Course { CourseCode = "DBAS 1007", Title = "Data Fundamentals" },
                        new Course { CourseCode = "DBAS 1020", Title = "Data Security" },
                        new Course { CourseCode = "DBAS 2010", Title = "Database Design II" },
                        new Course { CourseCode = "DBAS 2101", Title = "Data Reporting" },
						new Course { CourseCode = "DBAS 2103", Title = "Data Provisioning with ETL" },
                        new Course { CourseCode = "DBAS 2104", Title = "Business Analysis Essentials" },
                        new Course { CourseCode = "DBAS 3017", Title = "User Experience Techniques for Data" },
                        new Course { CourseCode = "DBAS 3018", Title = "Database Movement & Integration" },
                        new Course { CourseCode = "DBAS 3019", Title = "Business Data Modelling" },
                        new Course { CourseCode = "DBAS 3021", Title = "Metadata Management" },
                        new Course { CourseCode = "DBAS 3025", Title = "Information Governance" },
                        new Course { CourseCode = "DBAS 3035", Title = "Information Systems Design" },
                        new Course { CourseCode = "DBAS 3040", Title = "Database Mgmt & Administration" },
                        new Course { CourseCode = "DBAS 3060", Title = "Data Warehousing Support" },
                        new Course { CourseCode = "DBAS 3070", Title = "Intro to Enterprise Resource Planning" },
                        new Course { CourseCode = "DBAS 3075", Title = "Intro to Statistical Learning" },
                        new Course { CourseCode = "DBAS 3080", Title = "Database Backup and Recovery" },
                        new Course { CourseCode = "DBAS 3085", Title = "Data Security" },
                        new Course { CourseCode = "DBAS 3090", Title = "Applied Data Analytics" },
                        new Course { CourseCode = "DBAS 3200", Title = "Data-Driven Application Programming" },
                        new Course { CourseCode = "DBAS 4002", Title = "Transactional Database Programming" },
                        new Course { CourseCode = "DBAS 4075", Title = "Intro to Business Intelligence" },
                        new Course { CourseCode = "DBAS 5000", Title = "Database Development" },
						new Course { CourseCode = "DBAS 5010", Title = "Structured Query Language (SQL) for Analysts" },
						new Course { CourseCode = "DBAS 5015", Title = "Introduction to Data Science" },
						new Course { CourseCode = "DBAS 5020", Title = "Applied Data Science" },
						new Course { CourseCode = "ELEC 3000", Title = "Practical Electronics I" },
                        new Course { CourseCode = "ELEC 3010", Title = "Embedded Controllers I" },
						new Course { CourseCode = "ELEC 3011", Title = "Practical Electronics II" },
	                    new Course { CourseCode = "ELEC 3020", Title = "Embedded Controllers II" },
                        new Course { CourseCode = "HDWR 1700", Title = "Intro to Hardware & Security" },
                        new Course { CourseCode = "ICOM 1325", Title = "Project Management for IT" },
                        new Course { CourseCode = "ICOM 3010", Title = "Self Directed Study" },
                        new Course { CourseCode = "ICOM 5000", Title = "Business Development for IT" },
                        new Course { CourseCode = "ICOM 5010", Title = "Career Development for IT Professionals" },
                        new Course { CourseCode = "ICOM 5015", Title = "Agile Methodology" },
						new Course { CourseCode = "INET 2005", Title = "Web Application Programming I" },
                        new Course { CourseCode = "INET 3700", Title = "Server Operating Systems and Scripting" },
                        new Course { CourseCode = "INET 5010", Title = "Server-Side Programming" },
						new Course { CourseCode = "INFT 2007", Title = "Applied Semester Project I" },
                        new Course { CourseCode = "INFT 2100", Title = "Project Management" },
                        new Course { CourseCode = "INFT 3000", Title = "Capstone" },
	                    new Course { CourseCode = "INFT 3010", Title = "Capstone Project I" },
		                new Course { CourseCode = "INFT 3020", Title = "Capstone Project II" },							
                        new Course { CourseCode = "INFT 3075", Title = "Emerging Technologies" },
                        new Course { CourseCode = "INFT 4000", Title = "Special Topics I" },
                        new Course { CourseCode = "INFT 4001", Title = "Special Topics II" },
                        new Course { CourseCode = "ISEC 1005", Title = "Cyber Crime Survey" },
                        new Course { CourseCode = "ISEC 2022", Title = "Firewalls, VPNs, IPS, and Endpoints" },
                        new Course { CourseCode = "ISEC 2025", Title = "Vulnerabilities and Exploits" },
	                    new Course { CourseCode = "ISEC 2055", Title = "Web Application Security" },
                        new Course { CourseCode = "ISEC 2076", Title = "Security Mechanisms" },
                        new Course { CourseCode = "ISEC 2077", Title = "Security Auditing and Control Systems" },
                        new Course { CourseCode = "ISEC 2078", Title = "Wireless and Mobile Device Security" },
                        new Course { CourseCode = "ISEC 2079", Title = "Evolving Technologies and Threats" },
                        new Course { CourseCode = "ISEC 2700", Title = "Intro to Information Security Practices" },
                        new Course { CourseCode = "ISEC 3010", Title = "IoT Security" },
                        new Course { CourseCode = "ISEC 3050", Title = "Ethics and Law in Data Analytics" },
                        new Course { CourseCode = "ISEC 3077", Title = "Attack Vectors and Techniques" },
                        new Course { CourseCode = "ISEC 3078", Title = "Incidence Handling and Response" },
                        new Course { CourseCode = "ISEC 3079", Title = "Penetration Testing" },
                        new Course { CourseCode = "ISEC 3080", Title = "Enterprise Security" },
                        new Course { CourseCode = "ISEC 3700", Title = "Intro to Security Analysis and Implementation" },
                        new Course { CourseCode = "ISEC 3800", Title = "Advanced Security Implementation and Analysis" },
                        new Course { CourseCode = "ISEC 5000", Title = "Software Application Security" },
                        new Course { CourseCode = "MOBI 3000", Title = "Mobile Development" },
                        new Course { CourseCode = "MOBI 3002", Title = "Mobile App Development - Android" },
                        new Course { CourseCode = "NETW 1015", Title = "Network Security" },
                        new Course { CourseCode = "NETW 1300", Title = "Small Business Infrastructure" },
                        new Course { CourseCode = "NETW 1500", Title = "Intro to NOS Administration" },
                        new Course { CourseCode = "NETW 1700", Title = "Intro to Networking and Security" },
                        new Course { CourseCode = "NETW 2500", Title = "NOS Administration II" },
                        new Course { CourseCode = "NETW 2700", Title = "Network Infrastructure" },
                        new Course { CourseCode = "NETW 2710", Title = "Intro to Cloud Computing and Server Virtualization" },
                        new Course { CourseCode = "NETW 3012", Title = "Cloud Services" },
                        new Course { CourseCode = "NETW 3500", Title = "Enterprise Management and Automation" },
                        new Course { CourseCode = "NETW 3700", Title = "Hierarchical Network Infrastructure" },
                        new Course { CourseCode = "OSYS 1000", Title = "Operating Systems - UNIX" },
                        new Course { CourseCode = "OSYS 1020", Title = "Operating Systems Security" },
                        new Course { CourseCode = "OSYS 1200", Title = "Intro to Windows Administration" },
                        new Course { CourseCode = "OSYS 1700", Title = "Intro to Hardware & Operating Systems" },
                        new Course { CourseCode = "OSYS 2020", Title = "Windows Security" },
                        new Course { CourseCode = "OSYS 2022", Title = "Linux Scripting" },
                        new Course { CourseCode = "OSYS 2040", Title = "Web Server Fundamentals" },
                        new Course { CourseCode = "OSYS 3012", Title = "Embedded Operating Systems" },
                        new Course { CourseCode = "OSYS 3017", Title = "Database Server Management in Linux" },
                        new Course { CourseCode = "OSYS 3030", Title = "Network Services using Linux" },
                        new Course { CourseCode = "OSYS 5000", Title = "Operating Systems and Networking" },
						new Course { CourseCode = "PROG 1015", Title = "Programming for Security" },
                        new Course { CourseCode = "PROG 1400", Title = "Intro to Object Oriented Programming" },
                        new Course { CourseCode = "PROG 1700", Title = "Logic and Programming I" },
                        new Course { CourseCode = "PROG 2007", Title = "Programming II" },
                        new Course { CourseCode = "PROG 2022", Title = "Server Exploits" },
                        new Course { CourseCode = "PROG 2100", Title = "Programming C++" },
                        new Course { CourseCode = "PROG 2200", Title = "Advanced OOP" },
                        new Course { CourseCode = "PROG 2400", Title = "Data Structures" },
                        new Course { CourseCode = "PROG 2500", Title = "Windows Programming C#" },
                        new Course { CourseCode = "PROG 2700", Title = "Client-Side Programming" },
						new Course { CourseCode = "PROG 3011", Title = "Embedded C" },
                        new Course { CourseCode = "PROG 3012", Title = "IoT Programming with JavaScript" },
                        new Course { CourseCode = "PROG 3017", Title = "Full Stack Programming" },
                        new Course { CourseCode = "PROG 5010", Title = "Front-End Programming" },
                        new Course { CourseCode = "PROG 5015", Title = "Intro to Embedded Systems Programming" },
						new Course { CourseCode = "SAAD 1001", Title = "Intro to Systems Analysis & Design" },
                        new Course { CourseCode = "SAAD 1002", Title = "Intro to Systems Analysis & Design - ISM" },
                        new Course { CourseCode = "WEBD 1000", Title = "Website Development" },
                        new Course { CourseCode = "WEBD 2075", Title = "Web Security" },
                        new Course { CourseCode = "WEBD 3000", Title = "Web Application Programming II" },
                        new Course { CourseCode = "WEBD 3027", Title = "Developing for Content Management Systems" },	
                        new Course { CourseCode = "WEBD 3100", Title = "Web Design Fundamentals" },
                        new Course { CourseCode = "WEBD 3101", Title = "Ruby on Rails" },
						new Course { CourseCode = "WEBD 5000", Title = "HTML and CSS Fundamentals" },
						new Course { CourseCode = "WEBD 5010", Title = "Full Stack Web Development I" },
						new Course { CourseCode = "WEBD 5015", Title = "Full Stack Web Development II" }
                    );
                    context.SaveChanges();

                    //GET NEWLY CREATED COURSES FOR LATER USE
                    List<Course> generatedCourses = context.Courses.ToList();
                    
        #endregion //SEED COURSES

        #region SEED DIPLOMA YEARS

                    context.DiplomaYears.AddRange(
                        //Web Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Web Programming").Id
                        },
                        //Web Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Web Programming").Id
                        },
                        //Programming Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Programming").Id
                        },
                        //Programming Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Programming").Id
                        },
                        //Generalist Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Generalist").Id
                        },
                        //Generalist Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Generalist").Id
                        },
                        //Data Analytics Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Data Analytics").Id
                        },
                        //Data Analytics Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Data Analytics").Id
                        },
                        //DBA Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Database Administration").Id
                        },
                        //DBA Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Database Administration").Id
                        },
                        //SysMan Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Systems Management & Security").Id
                        },
                        //SysMan Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "IT - Systems Management & Security").Id
                        },
                        //Cyber Security Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "Cyber Security").Id
                        },
                        //Cyber Security Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "Cyber Security").Id
                        },
                        //Computer Electronics Technician Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "Computer Electronics Technician").Id
                        },
                        //Computer Electronics Technician Year 2
                        new DiplomaYear {
                            Title = "Year 2",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "Computer Electronics Technician").Id
                        },
                        //Business Intelligence Analytics Year 1
                        new DiplomaYear {
                            Title = "Year 1",
                            DiplomaId = generatedDiplomas.Find(d => d.Title == "Business Intelligence Analytics").Id
						},
	                    //Embedded Systems Programming Year 1
	                    new DiplomaYear {
	                        Title = "Year 1",
	                        DiplomaId = generatedDiplomas.Find(d => d.Title == "Embedded Systems Programming").Id
	                    },
	                    //Full Stack Application Development Year 1
	                    new DiplomaYear {
	                        Title = "Year 1",
	                        DiplomaId = generatedDiplomas.Find(d => d.Title == "Full Stack Application Development").Id
	                    }                              		
                    );
                    context.SaveChanges();

                    //GET NEWLY CREATED DIPLOMA PROGRAM YEAR IDS FOR LATER USE
                    List<DiplomaYear> generatedDiplomaYears = context.DiplomaYears.Include(dy => dy.Diploma).ToList();
                    
        #endregion //SEED DIPLOMA YEARS

        #region SEED DIPLOMA YEAR SECTIONS

                    context.DiplomaYearSections.AddRange(
                        #region 2018-19
                        //2018-19 - Web Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Web Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Web Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Web Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Programming Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Programming Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Generalist Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Generalist").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Generalist Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Generalist").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Data Analytics Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Data Analytics").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Data Analytics Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Data Analytics").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - DBA Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Database Administration").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - DBA Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Database Administration").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - SysMan Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - SysMan Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Cyber Security Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Cyber Security").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        //2018-19 - Computer Electronics Technician Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "Computer Electronics Technician").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id
                        },
                        #endregion //2018-19

                        #region 2019-20
			            //2019-20 - Web Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Web Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Web Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Web Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Programming Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Programming Year 1 - Section 2
                        new DiplomaYearSection {
                            Title = "Section 2",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Programming Year 1 - Section 3
                        new DiplomaYearSection {
                            Title = "Section 3",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Programming Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Generalist Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Generalist").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Data Analytics Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Data Analytics").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Data Analytics Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Data Analytics").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - DBA Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Database Administration").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - DBA Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Database Administration").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - SysMan Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - SysMan Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Cyber Security Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Cyber Security").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Cyber Security Year 2 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "Cyber Security").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
                        },
                        //2019-20 - Business Intelligence Analytics Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Business Intelligence Analytics").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id
						},
                        #endregion //2019-20

                        #region 2020-21
			            //2020-21 - Web Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Web Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
                        },
	                    //2020-21 - Web Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Web Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Programming Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Programming Year 1 - Section 2
	                    new DiplomaYearSection {
	                        Title = "Section 2",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Programming Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
		                //2020-21 - Programming Year 2 - Section 2
		                new DiplomaYearSection {
		                    Title = "Section 2",
		                    DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
		                    AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
		                },								
	                    //2020-21 - Data Analytics Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Data Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Data Analytics Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Data Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - DBA Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Database Administration").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - DBA Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Database Administration").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - SysMan Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - SysMan Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Cyber Security Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Cyber Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Cyber Security Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "Cyber Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Business Intelligence Analytics Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Business Intelligence Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
	                    //2020-21 - Embedded Systems Programming Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Embedded Systems Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id
	                    },
                        #endregion //2020-21
						
                        #region 2021-22
			            //2021-22 - Web Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Web Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
                        },
	                    //2021-22 - Web Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Web Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Programming Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Programming Year 1 - Section 2
	                    new DiplomaYearSection {
	                        Title = "Section 2",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Programming Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
		                //2021-22 - Programming Year 2 - Section 2
		                new DiplomaYearSection {
		                    Title = "Section 2",
		                    DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
		                    AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
		                },								
	                    //2021-22 - Data Analytics Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Data Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Data Analytics Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Data Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - DBA Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Database Administration").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - DBA Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Database Administration").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - SysMan Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - SysMan Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Cyber Security Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Cyber Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Cyber Security Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "Cyber Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Business Intelligence Analytics Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Business Intelligence Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Embedded Systems Programming Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Embedded Systems Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
	                    //2021-22 - Full Stack Application Development Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Full Stack Application Development").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id
	                    },
                        #endregion //2021-22
						
                        #region 2022-23
			            //2022-23 - Web Year 1 - Section 1
                        new DiplomaYearSection {
                            Title = "Section 1",
                            DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Web Programming").Id,
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
                        },
	                    //2022-23 - Web Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Web Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Programming Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Programming Year 1 - Section 2
	                    new DiplomaYearSection {
	                        Title = "Section 2",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Programming Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
		                //2022-23 - Programming Year 2 - Section 2
		                new DiplomaYearSection {
		                    Title = "Section 2",
		                    DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Programming").Id,
		                    AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
		                },								
	                    //2022-23 - Data Analytics Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Data Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Data Analytics Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Data Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - DBA Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Database Administration").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - DBA Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Database Administration").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - SysMan Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - SysMan Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "IT - Systems Management & Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Cyber Security Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Cyber Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Cyber Security Year 2 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 2" && dy.Diploma.Title == "Cyber Security").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Business Intelligence Analytics Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Business Intelligence Analytics").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Embedded Systems Programming Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Embedded Systems Programming").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    },
	                    //2022-23 - Full Stack Application Development Year 1 - Section 1
	                    new DiplomaYearSection {
	                        Title = "Section 1",
	                        DiplomaYearId = generatedDiplomaYears.Find(dy => dy.Title == "Year 1" && dy.Diploma.Title == "Full Stack Application Development").Id,
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id
	                    }
                        #endregion //2022-23
                    );
                    context.SaveChanges();

                    //GET NEWLY CREATED DIPLOMA PROGRAM YEAR SECTION IDS FOR LATER USE
                    List<DiplomaYearSection> generatedDiplomaYearSections = context.DiplomaYearSections.Include(dys => dys.AcademicYear).Include(dys => dys.DiplomaYear).ThenInclude(dy => dy.Diploma).ToList();
                    
        #endregion //SEED DIPLOMA YEAR SECTIONS
                    
        #region SEED SEMESTERS

                    context.Semesters.AddRange(
                        new Semester { 
                            Name = "Fall 2018", 
                            StartDate = DateTime.Parse("2018-09-06"), 
                            EndDate = DateTime.Parse("2018-12-15"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id 
                        },
                        new Semester { 
                            Name = "Winter 2019", 
                            StartDate = DateTime.Parse("2019-01-04"), 
                            EndDate = DateTime.Parse("2019-04-26"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id 
                        },
                        new Semester { 
                            Name = "Spring 2019", 
                            StartDate = DateTime.Parse("2019-04-29"), 
                            EndDate = DateTime.Parse("2019-05-31"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2018-19").Id 
                        },
                        new Semester { 
                            Name = "Fall 2019", 
                            StartDate = DateTime.Parse("2019-09-03"), 
                            EndDate = DateTime.Parse("2019-12-13"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id 
                        },
                        new Semester { 
                            Name = "Winter 2020", 
                            StartDate = DateTime.Parse("2020-01-06"), 
                            EndDate = DateTime.Parse("2020-04-24"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id 
                        },
                        new Semester { 
                            Name = "Spring 2020", 
                            StartDate = DateTime.Parse("2020-04-27"), 
                            EndDate = DateTime.Parse("2020-05-29"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2019-20").Id 
                        },
                        new Semester { 
                            Name = "Fall 2020", 
                            StartDate = DateTime.Parse("2020-09-11"), 
                            EndDate = DateTime.Parse("2020-12-18"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id 
                        },
                        new Semester { 
                            Name = "Winter 2021", 
                            StartDate = DateTime.Parse("2021-01-11"), 
                            EndDate = DateTime.Parse("2021-04-23"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id 
                        },
                        new Semester { 
                            Name = "Spring 2021", 
                            StartDate = DateTime.Parse("2021-04-27"), 
                            EndDate = DateTime.Parse("2021-05-29"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2020-21").Id 
                        },
                        new Semester { 
                            Name = "Fall 2021", 
                            StartDate = DateTime.Parse("2021-09-10"), 
                            EndDate = DateTime.Parse("2021-12-16"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id 
                        },
                        new Semester { 
                            Name = "Winter 2022", 
                            StartDate = DateTime.Parse("2022-01-10"), 
                            EndDate = DateTime.Parse("2022-04-20"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id 
                        },
                        new Semester { 
                            Name = "Spring 2022", 
                            StartDate = DateTime.Parse("2022-04-25"), 
                            EndDate = DateTime.Parse("2022-05-27"), 
                            AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id 
						},
	                    new Semester { 
	                        Name = "Fall 2022", 
	                        StartDate = DateTime.Parse("2022-09-05"), 
	                        EndDate = DateTime.Parse("2022-12-15"), 
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id 
	                    },
	                    new Semester { 
	                        Name = "Winter 2023", 
	                        StartDate = DateTime.Parse("2023-01-05"), 
	                        EndDate = DateTime.Parse("2023-04-19"), 
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2022-23").Id 
	                    },
	                    new Semester { 
	                        Name = "Spring 2023", 
	                        StartDate = DateTime.Parse("2023-04-25"), 
	                        EndDate = DateTime.Parse("2023-05-27"), 
	                        AcademicYearId = generatedAcademicYears.Find(ay => ay.Title == "2021-22").Id 
	                    }
                    );
                    context.SaveChanges();

                    //GET NEWLY CREATED SEMESTERS FOR LATER USE
                    List<Semester> generatedSemesters = context.Semesters.ToList();              

        #endregion //SEED SEMESTERS

        #region SEED ADVISING ASSIGNMENTS

                    context.AdvisingAssignments.AddRange(

			            #region 2018-19
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Generalist" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Generalist" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician" 
																						 && dys.AcademicYear.Title == "2018-19").Id
                        },
                        #endregion //2018-19

			            #region 2019-20
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Generalist" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2019-20").Id
                        },
                        #endregion //2019-20

			            #region 2020-21
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
	                    new AdvisingAssignment {
	                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
	                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2020-21").Id
	                    },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2020-21").Id
                        },
                        #endregion //2020-21
						
			            #region 2021-22
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
						new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
						new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },	
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
	                    new AdvisingAssignment {
	                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
	                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2021-22").Id
	                    },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development" 
																						 && dys.AcademicYear.Title == "2021-22").Id
                        },
                        #endregion //2021-22
						
			            #region 2022-23
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
						new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
						new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Web Programming" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
	                    new AdvisingAssignment {
	                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id,
	                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2022-23").Id
	                    },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Programming" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Street").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "IT - Database Administration" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 2" 
																						 && dys.DiplomaYear.Diploma.Title == "Cyber Security" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        },
                        new AdvisingAssignment {
                            InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                            DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																						 && dys.DiplomaYear.Title == "Year 1" 
																						 && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development" 
																						 && dys.AcademicYear.Title == "2022-23").Id
                        }
                        #endregion //2022-23
						
                    );
                    context.SaveChanges();

        #endregion

        #region SEED COURSE OFFERINGS

            context.CourseOfferings.AddRange(

                #region IT - WEB PROGRAMMING DIPLOMA

                    #region FALL 2018 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering 
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Warren").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    #endregion

                    #region WINTER 2019 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2040").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Johansen").Id
                    },
                    #endregion

                    #region FALL 2018 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Knott").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Chowdhary").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region WINTER 2019 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3027").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                        IsDirectedElective = true
                    },
                    #endregion 

                    #region FALL 2019 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering 
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    #endregion

                    #region WINTER 2020 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2040").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    #endregion

                    #region FALL 2019 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3100").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region WINTER 2020 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3027").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                        IsDirectedElective = true
                    },
                    #endregion        

                    #region FALL 2020 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering 
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Parks").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2021 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Muise").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2040").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion

                    #region FALL 2020 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Muise").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region WINTER 2021 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3027").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2055").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                        IsDirectedElective = true
                    },
                    #endregion   

                    #region FALL 2021 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering 
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2022 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2040").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    #endregion

                    #region FALL 2021 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region WINTER 2022 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3027").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id,
                        IsDirectedElective = true
                    },
                    #endregion 
							
                    #region FALL 2022 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering 
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Smith").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - WEB DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Sawler").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2040").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    #endregion
							
                    #region FALL 2022 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Kirkey").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id,
                        IsDirectedElective = true
                    },
                    #endregion
							
                    #region WINTER 2023 - WEB DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Sawler").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3027").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2055").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Web Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                #endregion //IT WEB PROGRAMMING DIPLOMA

                #region IT - PROGRAMMING DIPLOMA

                    #region FALL 2018 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2019 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2018 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2019 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    #endregion

                    #region FALL 2019 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2020 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2019 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2020 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2019 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 3
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    #endregion

                    #region WINTER 2020 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 3
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 3" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2019 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2020 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    #endregion

                    #region FALL 2020 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2021 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Muise").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Drover").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Muise").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2020 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2021 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Drover").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Muise").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion
					
                    #region FALL 2021 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2022 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2021 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2022 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion
							
                    #region FALL 2022 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Smith").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2023 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    #endregion
							
                    #region FALL 2022 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Smith").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion
	
                    #region WINTER 2023 - PROGRAMMING DIPLOMA - YEAR 1 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    #endregion
					
                    #region FALL 2020 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2021 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region FALL 2020 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2021 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion
					
                    #region FALL 2021 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dares").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2022 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id,
						IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2021 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dares").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2022 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id,
						IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2022 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2023 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Sawler").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Kowalski").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id,
						IsDirectedElective = true
                    },
                    #endregion
							
                    #region FALL 2022 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Trumbull").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region WINTER 2023 - PROGRAMMING DIPLOMA - YEAR 2 - SECTION 2
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Kowalski").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Kowalski").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 2" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id,
						IsDirectedElective = true
                    },
                    #endregion
					
                #endregion //IT - PROGRAMMING DIPLOMA                

                #region IT - GENERALIST DIPLOMA

                    #region FALL 2018 - GENERALIST DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    #endregion

                    #region WINTER 2019 - GENERALIST DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "South").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 1001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2018 - GENERALIST DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3100").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMP 2000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    #endregion

                    #region WINTER 2019 - GENERALIST DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CSTN 4015").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                    #region FALL 2019 - GENERALIST DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 3100").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Anne-Marie" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2100").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMP 2000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    #endregion

                    #region WINTER 2020 - GENERALIST DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 2005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id,
                        IsDirectedElective = true
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Generalist").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id,
                        IsDirectedElective = true
                    },
                    #endregion

                #endregion //IT - GENERALIST DIPLOMA            

                #region IT - SYSTEMS MANAGEMENT AND SECURITY DIPLOMA

                    #region FALL 2018 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "HDWR 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion

                    #region WINTER 2019 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2710").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1500").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region FALL 2018 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3030").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 1325").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    #endregion

                    #region WINTER 2019 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3800").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CSTN 4015").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion

                    #region FALL 2019 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "HDWR 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion

                    #region WINTER 2020 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2710").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    #endregion

                    #region FALL 2019 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3030").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 1325").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    #endregion

                    #region WINTER 2020 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3800").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CSTN 4015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion

                    #region FALL 2020 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "HDWR 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion

                    #region WINTER 2021 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McGillivary").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2710").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McGillivary").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region FALL 2020 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3030").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 1325").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    #endregion

                    #region WINTER 2021 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3800").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CSTN 4015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McGillivary").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion
					
                    #region FALL 2021 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "HDWR 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion

                    #region WINTER 2022 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2710").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region FALL 2021 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3030").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 1325").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    #endregion

                    #region WINTER 2022 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3800").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CSTN 4015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion
							
                    #region FALL 2022 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1200").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "HDWR 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2710").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion
							
                    #region FALL 2022 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 1325").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },							
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 2500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3030").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Smith").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "SAAD 1002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - SYSTEMS MANAGEMENT DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3800").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CSTN 4015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3500").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Systems Management & Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    #endregion				

                #endregion //IT - SYSTEMS MANAGEMENT AND SECURITY DIPLOMA            

                #region IT - DATA ANALYTICS DIPLOMA
                
                    #region FALL 2018 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "South").Id
                    },
                    #endregion

                    #region WINTER 2019 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region FALL 2018 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3019").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    #endregion

                    #region WINTER 2019 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3090").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region FALL 2019 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region WINTER 2020 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region FALL 2019 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3019").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    #endregion

                    #region WINTER 2020 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3090").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion

                    #region FALL 2020 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region WINTER 2021 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region FALL 2020 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3019").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    #endregion

                    #region WINTER 2021 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3090").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion
					
                    #region FALL 2021 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region WINTER 2022 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region FALL 2021 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3019").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    #endregion

                    #region WINTER 2022 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3090").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Kaur").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion
							
                    #region FALL 2022 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName=="Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - DATA ANALYTICS DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion
							
                    #region FALL 2022 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Pathak").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3019").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - DATA ANALYTICS DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3090").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Data Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    #endregion
					
                #endregion //IT - DATA ANALYTICS DIPLOMA

                #region IT - DATABASE ADMIN DIPLOMA

                    #region FALL 2018 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Warren").Id
                    },
                    #endregion

                    #region WINTER 2019 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1300").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    #endregion

                    #region FALL 2018 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3021").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    #endregion

                    #region WINTER 2019 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3035").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    #endregion

                    #region FALL 2019 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dutka").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region WINTER 2020 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1300").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    #endregion

                    #region FALL 2019 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3021").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    #endregion

                    #region WINTER 2020 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3035").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Arenburg").Id
                    },
                    #endregion

                    #region FALL 2020 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    #endregion

                    #region WINTER 2021 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1300").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McGillivary").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    #endregion

                    #region FALL 2020 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3021").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    #endregion

                    #region WINTER 2021 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Gillespie").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3035").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3025").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    #endregion

                    #region FALL 2021 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    #endregion

                    #region WINTER 2022 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1300").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region FALL 2021 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3017").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3021").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion

                    #region WINTER 2022 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3035").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion
							
                    #region FALL 2022 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hassan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1400").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Abu Baker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1300").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4002").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Campanis").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 1000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 2007").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion
							
                    #region FALL 2022 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3017").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3085").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3021").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - DATABASE ADMINISTRATION DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3018").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3035").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Im").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "IT - Database Administration").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3025").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    #endregion

                #endregion //IT - DATABASE ADMIN DIPLOMA            

                #region CYBER SECURITY DIPLOMA

                    #region FALL 2018 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Connell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 1005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region WINTER 2019 - DATABASE ADMINISTRATION DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region FALL 2019 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 1005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region WINTER 2020 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2025").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    #endregion

                    #region FALL 2019 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2076").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2077").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2078").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2079").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 2075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    #endregion

                    #region WINTER 2020 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3077").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3078").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3079").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    #endregion

                    #region FALL 2020 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 1005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region WINTER 2021 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    #endregion

                    #region FALL 2020 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2076").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2077").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2078").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2079").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 2075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    #endregion

                    #region WINTER 2021 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3077").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3078").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Emma" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3079").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    #endregion

                    #region FALL 2021 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1015").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 1005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion

                    #region WINTER 2022 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    #endregion

                    #region FALL 2021 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2076").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2077").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2078").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2079").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 2075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    #endregion

                    #region WINTER 2022 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3077").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3078").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3079").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Paul" && i.LastName == "Street").Id
                    },
                    #endregion
							
                    #region FALL 2022 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 1700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Singh").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 1020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 1005").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - CYBER SECURITY DIPLOMA - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 2700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2022").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 2022").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 2020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Kearney").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Bigley").Id
                    },
                    #endregion
							
                    #region FALL 2022 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2076").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2077").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2078").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 2079").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Hinton").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 2075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Lin").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - CYBER SECURITY DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3077").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3078").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3079").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Cyber Security").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3080").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    #endregion

                #endregion //CYBER SECURITY DIPLOMA

                #region COMPUTER ELECTRONICS TECHNICIAN DIPLOMA

                    #region FALL 2018 - COMPUTER ELECTRONICS TECHNICIAN DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 3700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 2015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 3025").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 2000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Russell").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2018").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 1015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    #endregion

                    #region WINTER 2019 - COMPUTER ELECTRONICS TECHNICIAN DIPLOMA - YEAR 2 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "COMM 4700").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Scarfone").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 2020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 2105").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 3020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 2" && dys.DiplomaYear.Diploma.Title == "Computer Electronics Technician").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "CETN 3001").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    }, 
                    #endregion
                
                #endregion //COMPUTER ELECTRONICS TECHNICIAN DIPLOMA

                #region BUSINESS INTELLIGENCE ANALYTICS

                    #region FALL 2019 - BUSINESS INTELLIGENCE ANALYTICS - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2101").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2019").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "D'Entremont").Id
                    },
                    #endregion

                    #region WINTER 2020 - BUSINESS INTELLIGENCE ANALYTICS - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2103").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3090").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 3075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3050").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McLeod").Id
                    },
                    #endregion
							
                    #region FALL 2022 - BUSINESS INTELLIGENCE ANALYTICS - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2101").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 4075").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2104").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Cunningham").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - BUSINESS INTELLIGENCE ANALYTICS - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 2103").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 4001").Id,
                        InstructorId = null //generatedInstructors.Find(i => i.LastName == "").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 5020").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Business Intelligence Analytics").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Dolinger").Id
                    },
                    #endregion

                #endregion //BUSINESS INTELLIGENCE ANALYTICS

                #region EMBEDDED SYSTEMS PROGRAMMING

                    #region FALL 2020 - EMBEDDED SYSTEMS PROGRAMMING - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "O'Driscoll").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3011").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2020").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion

                    #region WINTER 2021 - EMBEDDED SYSTEMS PROGRAMMING - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "McGillivary").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Muise").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3011").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion
										
                    #region FALL 2021 - EMBEDDED SYSTEMS PROGRAMMING - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3011").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion

                    #region WINTER 2022 - EMBEDDED SYSTEMS PROGRAMMING - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3011").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion
							
                    #region FALL 2022 - EMBEDDED SYSTEMS PROGRAMMING - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Crocker").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3011").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - EMBEDDED SYSTEMS PROGRAMMING - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Mogensen").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "NETW 3012").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "MOBI 3000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ELEC 3020").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 3011").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Shewan").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Embedded Systems Programming").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INFT 3010").Id,
                        InstructorId = generatedInstructors.Find(i => i.FirstName == "Todd" && i.LastName == "Verge").Id
                    },
                    #endregion

                #endregion //EMBEDDED SYSTEMS PROGRAMMING

				#region FULL STACK APPLICATION DEVELOPMENT
				
                    #region FALL 2021 - FULL STACK APPLICATION DEVELOPMENT - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2021").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    #endregion

                    #region WINTER 2022 - FULL STACK APPLICATION DEVELOPMENT - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
					},
                    #endregion				
				
                    #region FALL 2022 - FULL STACK APPLICATION DEVELOPMENT - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "OSYS 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" 
																					 && dys.DiplomaYear.Title == "Year 1" 
																					 && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "PROG 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "DBAS 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "INET 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Fall 2022").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Joy").Id
                    },
                    #endregion
							
                    #region WINTER 2023 - FULL STACK APPLICATION DEVELOPMENT - YEAR 1 - SECTION 1
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ISEC 5000").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "WEBD 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "APPD 5015").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Caines").Id
                    },
                    new CourseOffering
                    {
                        SemesterId = generatedSemesters.Find(s => s.Name == "Winter 2023").Id,
                        DiplomaYearSectionId = generatedDiplomaYearSections.Find(dys => dys.Title == "Section 1" && dys.DiplomaYear.Title == "Year 1" && dys.DiplomaYear.Diploma.Title == "Full Stack Application Development").Id,
                        CourseId = generatedCourses.Find(c => c.CourseCode == "ICOM 5010").Id,
                        InstructorId = generatedInstructors.Find(i => i.LastName == "Tsaltas").Id
                    } //No comma here...end of items
                    #endregion
				
				#endregion //FULL STACK APPLICATION DEVELOPMENT

            );
            context.SaveChanges();

        #endregion //SEED COURSE OFFERINGS	    		        

        #region SEED COURSE PREREQUISITES

                Tuple<string, string>[] courseAndPreReqPairs =
                {
                    //                         COURSE   ,   PREREQ
                    //APPD 5010
					new Tuple<string,string>("APPD 5010", "APPD 5000"),
					new Tuple<string,string>("APPD 5010", "WEBD 5000"),
					new Tuple<string,string>("APPD 5010", "OSYS 5000"),
					new Tuple<string,string>("APPD 5010", "PROG 5010"),
					new Tuple<string,string>("APPD 5010", "INET 5010"),
					new Tuple<string,string>("APPD 5010", "DBAS 5000"),
                    //APPD 5015
					new Tuple<string,string>("APPD 5015", "APPD 5000"),
					new Tuple<string,string>("APPD 5015", "WEBD 5000"),
					new Tuple<string,string>("APPD 5015", "OSYS 5000"),
					new Tuple<string,string>("APPD 5015", "PROG 5010"),
					new Tuple<string,string>("APPD 5015", "INET 5010"),
					new Tuple<string,string>("APPD 5015", "DBAS 5000"),
					//CETN 1015
                    new Tuple<string,string>("CETN 1015", "CETN 1000"),
                    new Tuple<string,string>("CETN 1015", "CETN 2700"),
                    //CETN 2015
                    new Tuple<string,string>("CETN 2015", "CETN 2005"),
                    //CETN 2020
                    new Tuple<string,string>("CETN 2020", "CETN 3025"),
                    //CETN 2105
                    new Tuple<string,string>("CETN 2105", "CETN 2020"),
                    //CETN 3001
                    new Tuple<string,string>("CETN 3001", "CETN 3010"),
                    //CETN 3010
                    new Tuple<string,string>("CETN 3010", "PROG 1700"),
                    //CETN 3025
                    new Tuple<string,string>("CETN 3025", "CETN 2015"),
                    //COMM 2700
                    new Tuple<string,string>("COMM 2700", "COMM 1700"),
                    //COMM 3700
                    new Tuple<string,string>("COMM 3700", "COMM 2700"),
                    //COMM 4700
                    new Tuple<string,string>("COMM 4700", "COMM 3700"),
                    //COMP 2000
                    new Tuple<string,string>("COMP 2000", "COMM 2700"),
                    //DBAS 3017
                    new Tuple<string,string>("DBAS 3017", "DBAS 2104"),
                    new Tuple<string,string>("DBAS 3017", "DBAS 4002"),
                    new Tuple<string,string>("DBAS 3017", "PROG 1400"),
                    new Tuple<string,string>("DBAS 3017", "WEBD 1000"),
                    //DBAS 3018
                    new Tuple<string,string>("DBAS 3018", "DBAS 4002"),
                    //DBAS 3019
                    new Tuple<string,string>("DBAS 3019", "DBAS 1007"),
                    new Tuple<string,string>("DBAS 3019", "DBAS 2104"),
                    //DBAS 3021
                    new Tuple<string,string>("DBAS 3021", "DBAS 1007"),
                    new Tuple<string,string>("DBAS 3021", "DBAS 4002"),
                    //DBAS 3025
                    new Tuple<string,string>("DBAS 3025", "DBAS 2104"),
                    new Tuple<string,string>("DBAS 3025", "DBAS 3085"),
                    new Tuple<string,string>("DBAS 3025", "ISEC 3050"),
                    //DBAS 3035
                    new Tuple<string,string>("DBAS 3035", "PROG 1400"), 
                    //DBAS 3080
                    new Tuple<string,string>("DBAS 3080", "OSYS 3017"),
                    //DBAS 3085
                    new Tuple<string,string>("DBAS 3085", "DBAS 4002"),
                    new Tuple<string,string>("DBAS 3085", "NETW 1700"),
                    new Tuple<string,string>("DBAS 3085", "OSYS 1700"),
                    //DBAS 3090
                    new Tuple<string,string>("DBAS 3090", "DBAS 3017"),
                    new Tuple<string,string>("DBAS 3090", "DBAS 3018"),
                    new Tuple<string,string>("DBAS 3090", "DBAS 3019"),
                    //DBAS 3200
                    new Tuple<string,string>("DBAS 3200", "PROG 1400"),
                    //DBAS 4002
                    new Tuple<string,string>("DBAS 4002", "DBAS 1007"),
                    new Tuple<string,string>("DBAS 4002", "PROG 1700"),
					//DBAS 5020
					new Tuple<string,string>("DBAS 5020", "DBAS 5015"),
                    //ELEC 3011
                    new Tuple<string,string>("ELEC 3011", "ELEC 3000"),
                    //ELEC 3020
                    new Tuple<string,string>("ELEC 3020", "ELEC 3010"),
                    //ICOM 1325
                    new Tuple<string,string>("ICOM 1325", "COMM 2700"),
                    //ICOM 5015
                    new Tuple<string,string>("ICOM 5015", "APPD 5000"),
                    //INET 2005
                    new Tuple<string,string>("INET 2005", "DBAS 1007"),
                    new Tuple<string,string>("INET 2005", "PROG 1400"),
                    new Tuple<string,string>("INET 2005", "WEBD 1000"),                                        
                    //INET 3700
                    new Tuple<string,string>("INET 3700", "NETW 1700"),
                    new Tuple<string,string>("INET 3700", "OSYS 1000"),
                    new Tuple<string,string>("INET 3700", "OSYS 1700"), 
                    new Tuple<string,string>("INET 3700", "PROG 1700"), 
                    //ISEC 2022
                    new Tuple<string,string>("ISEC 2022", "NETW 1015"),
                    //ISEC 2025
                    new Tuple<string,string>("ISEC 2025", "ISEC 1005"),
                    new Tuple<string,string>("ISEC 2025", "NETW 1015"),
                    new Tuple<string,string>("ISEC 2025", "OSYS 1020"),
                    new Tuple<string,string>("ISEC 2025", "PROG 1015"),                    
                    //ISEC 2055
                    new Tuple<string,string>("ISEC 2055", "INET 2005"),
                    new Tuple<string,string>("ISEC 2055", "PROG 2700"),
                    //ISEC 2077
                    new Tuple<string,string>("ISEC 2077", "OSYS 2020"),
                    new Tuple<string,string>("ISEC 2077", "NETW 1015"),
                    //ISEC 3010
                    new Tuple<string,string>("ISEC 3010", "OSYS 3012"),
                    //ISEC 3077
                    new Tuple<string,string>("ISEC 3077", "WEBD 2075"),
                    //ISEC 3080
                    new Tuple<string,string>("ISEC 3080", "OSYS 2020"),
                    new Tuple<string,string>("ISEC 3080", "NETW 1015"),
                    //ISEC 3700
                    new Tuple<string,string>("ISEC 3700", "ISEC 2700"),
                    new Tuple<string,string>("ISEC 3700", "NETW 1700"),
                    //ISEC 3800
                    new Tuple<string,string>("ISEC 3800", "ISEC 3700"),
					//ISEC 5000
					new Tuple<string,string>("ISEC 5000", "APPD 5000"),
					new Tuple<string,string>("ISEC 5000", "WEBD 5000"),
					new Tuple<string,string>("ISEC 5000", "OSYS 5000"),
					new Tuple<string,string>("ISEC 5000", "PROG 5010"),
					new Tuple<string,string>("ISEC 5000", "INET 5010"),
					new Tuple<string,string>("ISEC 5000", "DBAS 5000"),
                    //MOBI 3000
                    new Tuple<string,string>("MOBI 3000", "PROG 3012"),
                    new Tuple<string,string>("MOBI 3000", "PROG 3011"),
                    new Tuple<string,string>("MOBI 3000", "ELEC 3000"),
                    //MOBI 3002
                    new Tuple<string,string>("MOBI 3002", "PROG 1400"),
                    //NETW 1500
                    new Tuple<string,string>("NETW 1500", "OSYS 1200"),
                    //NETW 2500
                    new Tuple<string,string>("NETW 2500", "NETW 1500"),
                    //NETW 2700
                    new Tuple<string,string>("NETW 2700", "NETW 1700"),
                    //NETW 2710
                    new Tuple<string,string>("NETW 2710", "NETW 1700"),
                    new Tuple<string,string>("NETW 2710", "OSYS 1200"),
                    //NETW 3012
                    new Tuple<string,string>("NETW 3012", "PROG 3012"),
                    //NETW 3500
                    new Tuple<string,string>("NETW 3500", "NETW 1500"),
                    //NETW 3700
                    new Tuple<string,string>("NETW 3700", "NETW 2700"),
                    //OSYS 2020
                    new Tuple<string,string>("OSYS 2020", "OSYS 1020"),
                    //OSYS 2022
                    new Tuple<string,string>("OSYS 2022", "OSYS 1020"),
                    //OSYS 2040
                    new Tuple<string,string>("OSYS 2040", "OSYS 1000"),
                    //OSYS 3017
                    new Tuple<string,string>("OSYS 3017", "DBAS 4002"),
                    new Tuple<string,string>("OSYS 3017", "INET 3700"),
                    new Tuple<string,string>("OSYS 3017", "NETW 1700"),
                    new Tuple<string,string>("OSYS 3017", "OSYS 1000"),
                    //OSYS 3030
                    new Tuple<string,string>("OSYS 3030", "OSYS 1000"),
                    //PROG 1400
                    new Tuple<string,string>("PROG 1400", "PROG 1700"),
                    //PROG 2007
                    new Tuple<string,string>("PROG 2007", "PROG 1700"),
                    //PROG 2022
                    new Tuple<string,string>("PROG 2022", "PROG 1015"),
                    new Tuple<string,string>("PROG 2022", "DBAS 1020"),
                    //PROG 2100
                    new Tuple<string,string>("PROG 2100", "PROG 1400"),
                    new Tuple<string,string>("PROG 2100", "SAAD 1001"),
                    //PROG 2200
                    new Tuple<string,string>("PROG 2200", "PROG 1400"),
                    new Tuple<string,string>("PROG 2200", "SAAD 1001"),
                    //PROG 2400
                    new Tuple<string,string>("PROG 2400", "PROG 2100"),
                    //PROG 2500
                    new Tuple<string,string>("PROG 2500", "PROG 1400"),
                    new Tuple<string,string>("PROG 2500", "SAAD 1001"),
                    //PROG 2700
                    new Tuple<string,string>("PROG 2700", "PROG 1700"),
                    new Tuple<string,string>("PROG 2700", "WEBD 1000"),
                    //PROG 3017
                    new Tuple<string,string>("PROG 3017", "DBAS 1007"),
                    new Tuple<string,string>("PROG 3017", "PROG 1400"),
                    new Tuple<string,string>("PROG 3017", "PROG 2700"),
                    //SAAD 1001
                    new Tuple<string,string>("SAAD 1001", "PROG 1700"),
                    //SAAD 1002
                    new Tuple<string,string>("SAAD 1002", "NETW 1700"),
                    //WEBD 2075
                    new Tuple<string,string>("WEBD 2075", "PROG 2022"),
                    //WEBD 3000
                    new Tuple<string,string>("WEBD 3000", "INET 2005"),
                    //WEBD 3027
                    new Tuple<string,string>("WEBD 3027", "INET 2005"),
                    //WEBD 3100
                    new Tuple<string,string>("WEBD 3100", "WEBD 1000"),
                    //WEBD 5010
                    new Tuple<string,string>("WEBD 5010", "APPD 5000"),
					new Tuple<string,string>("WEBD 5010", "WEBD 5000"),
					new Tuple<string,string>("WEBD 5010", "OSYS 5000"),
					new Tuple<string,string>("WEBD 5010", "PROG 5010"),
					new Tuple<string,string>("WEBD 5010", "INET 5010"),
					new Tuple<string,string>("WEBD 5010", "DBAS 5000"),
					//WEBD 5015
					new Tuple<string,string>("WEBD 5015", "WEBD 5010"),
                };

                //VERSION 1 of Course Prerequisites
                foreach(Tuple<string,string> courseAndPreReqPair in courseAndPreReqPairs)
                {
                    context.CoursePrerequisites.Add(
                        new CoursePrerequisite {
                            CourseId = generatedCourses.Find(c => c.CourseCode == courseAndPreReqPair.Item1).Id,
                            PrerequisiteId = generatedCourses.Find(c => c.CourseCode == courseAndPreReqPair.Item2).Id
                        }
                    );
                }

                // //VERSION 2 of Course Prerequisites
                // Course course = null;
                // foreach(Tuple<string,string> courseAndPreReqPair in courseAndPreReqPairs)
                // {
                //     if(course == null || course.CourseCode != courseAndPreReqPair.Item1){
                //         course = context.Courses.Where(c => c.CourseCode == courseAndPreReqPair.Item1).First();
                //     }
                //     course.Prerequisites.Add(context.Courses.Where(c => c.CourseCode == courseAndPreReqPair.Item2).First());
                // }

                context.SaveChanges();

        #endregion //SEED COURSE PREREQUISITES

        }
    }
}
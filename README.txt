






Requirements:
	Display information from database in table form.

Constraints:
	Utilize web client, web server and data source three tier architecture to present data to customer.
	The web application will present data to the client from a data source with data imported from a 
	spreadsheet.  ASP.NET must be used on the web server implementing the MVC design pattern.  	It is also the customers preference to use BootStrap template and Jquery DataTables to present 	the table data on the web client.


Design Summary:
	The MVC model, view, controller pattern is used.
	Model
		Data First Code design using LINQ to Sql to gain data Context.  Table data must be 			imported from spreadsheet.  Microsoft SQL Server 2014 express contains the database 			and facilitates the import from spreadsheet.
	View
		The view implements jquery DataTables and bootstrap template.
	Controller
		The controller implements the TableContextDataContext class to retrieve data from the database.
		


Assumptions:
	It is assumed the customer is using a javascript compatible web browser  


Customer Table Model Detail

	[id] [float] NOT NULL,
	[first_name] [nvarchar](255) NULL,
	[last_name] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[phone] [nvarchar](255) NULL,
	[street] [nvarchar](255) NULL,
	[city] [nvarchar](255) NULL,
	[region] [nvarchar](255) NULL,
	[postal_code] [float] NULL,
	[country] [nvarchar](255) NULL,
	[dob] [nvarchar](255) NULL,

Customer View Detail
Jquery DataTables formats the table with a simple vertical scroll bar.

        $(document).ready(function () {
            $('#tblCust').dataTable({
                "scrollY": "200px",
                "scrollCollapse": true,
                "paging": false
            });
        });

The html helper populates the table:
            @foreach (var item in Model)
            {
                <tr>
                    <td>@item.id</td>
                    <td>@item.first_name</td>
                    <td>@item.last_name</td>
                    <td>@item.phone</td>
                    <td>@item.dob</td>
                    <td>@item.city</td>
                    <td>@item.country</td>
                    <td>@item.email</td>
                    <td>@item.region</td>
                    <td>@item.street</td>
                </tr>
            }
The bootstrap Template adds a navigation bar to the page:
    <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">Data Table</a>
            </div>
            <div id="navbar" class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="#">Home</a></li>
                    <li><a href="#about">About</a></li>
                    <li><a href="#contact">Contact</a></li>
                </ul>
            </div><!--/.nav-collapse -->
            <br />
        </div>
    </nav>

Controller Detail

Returns Customer List objects to view:


        public ActionResult Index()
        {
            
            //get customer list and return it to view
            return View(_dataModel.Customers.ToList());
        }

Installation
	It is necessary to create an SQL database to import data from the spreadsheet.  Scripts are included in the SQL scripts folder.  Use the create.sql script to create the initial database.  After the initial import it is necessary to copy the imported table data into the Customer table.  Use the copy.sql script to copy the data.



In Web.Config the Connection string must be changed to match the server settings.
<add name="DevelopmentTestConnectionString" connectionString="Data Source=RICHARD-PC\SQLEXPRESS;Initial Catalog=DevelopmentTest;User ID=sa;Password=wizard26" providerName="System.Data.SqlClient" />

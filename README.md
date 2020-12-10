# EvolentHealth
EvolentHealth Assignment

1-First you should change the connetionstring from Appsetting file.Put you sql db connection string here.

"ConnectionStrings": {
    "Default": "server=PRADEEPKUMAR_IT;database=EvolentHealthDb;Integrated Security=SSPI"
  },


2- Run the below command in Package-Manage console window for create database and tables. Before run the command you should delete all the files under Migration folder. Then run it.

  -Add-Migration EvolentDbCreate
  -update-database
  
3- After run the command you should ensure that database and tables are created successfully in Sql server. Then run the application.

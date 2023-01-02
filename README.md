# MEalAPI

This repo contains the source code for the back-end ASP.NET Core API for the
MEal meal-planning web application.

## Getting Started
1. Install Visual Studio Community (>=2022). Ensure to add the Database and
   Javascript add-ons.
2. Clone the repos locally.
3. (Optional) Create a new Solution and add both the the MEalAPI csproj and the MEalClient
   esproj to it.
4. Install the project dependencies using either dotnet via powershell or the
   Visual Studio package wizard or CLI. The project packages are listed in `MEalAPI.csproj`.
	* Follow the steps at [Install EF Core](https://docs.microsoft.com/en-us/ef/core/get-started/overview/install)
	  to install the ef core tools.
5. Install PostgreSQL v14.
6. Apply the latest database migration by running `dotnet ef database update`.
7. Using Jetbrain's DataGrip (or whichever database IDE or the built-in Visual
   Studio SQL tools) create a new connection using the connection details in
   `appsettings.json`. NOTE: This needs to be changed to use [Secret Manager](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows).
8. Copy `SeedData/meal_seed_data.sql` into a new console session using the new
  connection and run to add the seed data to the database.

## Database
### Start from scratch
1. Close all connections and delete the database by running `dropdb.exe --host localhost --username postgres --port 5432 --echo meal`.
2. Delete the migration entries under the `Migrations` directory.
3. Run:
```powershell
dotnet ef migrations add InitialCreate
dotnet ef database update
```
References: https://stackoverflow.com/a/16082497

## Tutorials
### [User Registration with Angular and ASP.NET Core Identity | CodeMaze](https://code-maze.com/user-registration-angular-aspnet-identity/)
When you clone (or download the zip) the [source code's repo on Github](https://github.com/CodeMazeBlog/angular-identity-aspnetcore-security/tree/angular-identity-user-registration),
the database set up is broken and gives a [Microsoft.Data.SqlClient.SqlException (0x80131904)](https://stackoverflow.com/questions/26135346/sql-connection-error-system-data-sqlclient-sqlexception-0x80131904).
I remembered seeing a simliar issue when first trying to re-create my PostgreSQL
instance on my laptop after it was factory-reset and I realized that I had
simply forgotton to install PostgreSQL again. To fix the database, I did a
couple of things (partially taken from [How to delete and recreate from scratch an existing EF Code First database](https://stackoverflow.com/questions/16035333/how-to-delete-and-recreate-from-scratch-an-existing-ef-code-first-database):
1. Make sure to install [Microsoft SQL Server on-premises](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
   and [Microsoft SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver16).
   The MSSQL server installer should prompt you or provide a link to the MSSQLMS
   download page.
2. Update the `sqlConnection` config value in `appsettings.json` to the following:
   ```json
   "sqlConnection": "Server=(localdb)\\mssqllocaldb;Database=CompanyEmployees;Trusted_Connection=True;MultipleActiveResultSets=true"
   ```
3. Run these commands to remove the existing migrations:
	```powershell
	dotnet ef database update 0

	# You might need to run this a couple times
	dotnet ef migrations remove

	dotnet ef migrations add InitialCreate

	dotnet ef database update
	```
4. The database issue should now be fixed and include the seed data. You can run
   the ClientApp and check to see if the companies appear and no error is thrown
   in the WebApi.

Alternatively, you could probably swap out MSSQL Server for [.NET's InMemory db provider](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory).
Here are [Other Entity-supported database providers](https://docs.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli).
Here you can see [more dotnet ef commands and options](https://docs.microsoft.com/en-us/ef/core/cli/dotnet).

### Installing Ubuntu Server
The first time I tried creating a bootable media for Ubuntu Server, I didn't have
a spare USB stick so I tried using my 500GB Sandisk SSD which had worked when I
did created a Windows installer media to do a fresh install of Windows on my
laptop. The Ubuntu tutorial's (and the youtube one) reccomendation is to use
Balena Etcher to create the bootable USB. When I tried this, however, the
computer wouldn't display the disk on the boot menu. Then I tried plugging it back
into my laptop and re-formatting it, but Windows would no longer recognize/display
it. Googling around, it looks like this is apparently a semi-frequent problem
with the application because I found an entire article from the maintainers about
fixing this issue. I followed the steps and it the disk still wouldn't show up in
the file explorer (although it is at least being sem-recognized by windows now
as the eject option shows up in the windows system tray and it doesn't throw an
error when you plug it in now).

Since I had apparently borked my SSD drive (until I can figure out how to fix it)
I went and got a couple cheap USB drives and tried the process again but using
Rufus. This worked no-problem first-try. So I'm not sure if Balena doesn't work
on external SSDs or what happened, but yeah...
- [Ubuntu Server 20.04 LTS Install - A Step by Step Guide - (Beginners Tutorial and Bonus! Web Server) | YouTube](https://www.youtube.com/watch?v=xUH256WAWt0)
- [Get Ubuntu Server | Ubuntu](https://ubuntu.com/download/server)
- [Create a bootable USB stick with Rufus on Windows | Ubuntu](https://ubuntu.com/tutorials/create-a-usb-stick-on-windows#1-overview)
- [Create bootable USB drives the easy way | Rufus](https://rufus.ie/en/)
- [Install Ubuntu Server | Ubuntu](https://ubuntu.com/tutorials/install-ubuntu-server#1-overview)

### Installing and Configuring Apache Web Server on Ubuntu Server
- [How To Install the Apache Web Server on Ubuntu 20.04 | Digital Ocean](https://www.digitalocean.com/community/tutorials/how-to-install-the-apache-web-server-on-ubuntu-20-04)
- [Install and Configure Apache Web Server on Ubuntu 20.04 | linuxhint](https://linuxhint.com/install_apache_web_server_ubuntu/)
- [Getting Started | Apache](https://httpd.apache.org/docs/2.4/getting-started.html)

### Purchase and Configure Your Domain (and Sub-domains)
- [Google Domains](https://domains.google.com)
- [Features | Google Domains](https://support.google.com/domains/answer/4632243?hl=en)
- [Manage resource records | Google Domains](https://support.google.com/domains/answer/3290350#zippy=,add-a-resource-record,modify-or-delete-a-resource-record,host-name)
- [Resource record types | Google Domains](https://support.google.com/domains/answer/10751068#zippy=,cname)
- [Static vs. dynamic IP addresses | Google Domains](https://support.google.com/fiber/answer/3547208?hl=en)
- [Configure DNS for your network | Google Domains](https://support.google.com/fiber/answer/4647563)
- [How changes propagate to Google services | Google Domains](https://support.google.com/a/answer/7514107?hl=en#:~:text=The%20time%20it%20takes%20depends,your%20domain%20host%20for%20details.)
- [Connect your website to a domain registered through Google | Google Domains](https://support.google.com/a/answer/7538152?hl=en#zippy=,my-domain-registrar-is-google-domains,for-an-a-record,for-a-cname-record,for-a-name-server-ns-record)
- [Learn about Dynamic DNS | Google Domains](https://support.google.com/domains/answer/6147083?hl=en#zippy=,set-up-a-client-program-on-your-gateway-host-or-server)
- [ddclient | Ubuntu](https://help.ubuntu.com/community/DynamicDNS)
- [How to set up a wildcard subdomain on Google Domains](https://blog.andersonbanihirwe.dev/posts/2021/google-dynamic-dns-wildcard-subdomains/)

After following the above tutorials I created two 'A' entries that pointed
(erroneously) to my server's internal IP address: one for nbrinton.dev and one
for *.nbrinton.dev. I was still having issues accessing either sub-domain (or
the main domain) outside of our wifi. Ethan came over for help with a work issue
and took a look at my DNS and router configuration while he was here. I had
mostly set things up correctly, but was missing one thing and slightly off on
another.

Make sure to use the public-facing WAN IP-address. You can find this by going
to your router's default gateway IP (find by running `ifconfig` (or `ipconfig`)
and then looking for it there. Once you have this, make an 'A' record that
points to that address. In my case, I accidentally used the internal IP address
of my server box which is why people were getting a timeout when trying to visit
it outside of my network but I could still reach it.

Once you have this record saved, go back to your router settings, navigate to
the WAN settings, then the Virtual Server / Port Forwarding tab/section. Make
sure to turn on port-forwarding and then create an entry in the port forward
list that maps the a specific external port to the Internal IP address of your
server.

Also, I had added 'AAAA' type records for IPv6 when my IP address does not
actually have IPv6 and only has IPv4. So I went ahead and deleted those entries.

Ethan used [nslookup](https://www.nslookup.io), [ipmonkey](http://ipmonkey.com)
and [canyouseeme](https://canyouseeme.org) to see if my domain was properly
mapping to my WAN IP-address and if it was accessible publicly.

The other problem with the two 'A' records that I set up was that they were
configured with the assumption that my IP address was static when in fact it is
dynamic. I followed the bottom three pages listed above in order to set up
dynamic DNS so that the IP address in the 'A' records is automatically updated
whenever it changes.

### Set Up Virtual Hosts in Apache
In order to easily run multiple websites on a single server using Apache, you
want to create and use name-based Virtual Hosts.
- [How To Set Up Apache Virtual Hosts on Ubuntu 20.04 | Digital Ocean](https://www.digitalocean.com/community/tutorials/how-to-set-up-apache-virtual-hosts-on-ubuntu-20-04)
- [Name-based Virtual Host Support | Apache](https://httpd.apache.org/docs/2.4/vhosts/name-based.html)
- [VirtualHost Examples | Apache](https://httpd.apache.org/docs/2.4/vhosts/examples.html)

### Setting Up SSL Certification
Since the domain I purchased (nbrinton.dev) has a .dev domain ending, it forces
the use of HTTPS in web-browsers using HSTS. Because of this, I was able to use
curl to test out the virtual hosts I had set up ([meal.nbrinton.dev](https://meal.nbrinton.dev)
and [www.nbrinton.dev](https://www.nbrinton.dev)) by just using HTTP but was
getting an error when trying to access in Chrome or Vivaldi as it was automatically
redirecting to use HTTPS when I hadn't set up the SSL certificates yet.

Also of note, because of the automatic requirement of .dev forwarding to HTTPS,
I wasn't able to follow the basic use-case for certbot since that requires your
website to already be up-and-running and reachable via HTTP. This is why I had
to use DNS validation to get my certificates using certbot by following the
Digital Ocean tutorial.
- [SSL/TLS Strong Encryption: Hot-To | Apache](https://httpd.apache.org/docs/2.4/ssl/ssl_howto.html)
- [Use Hypertext Transfer Protocol Secure (HTTPS) on your domain | Google Domains](https://support.google.com/domains/answer/7630973?hl=en&visit_id=637974871380003441-2921542600&rd=1#zippy=,get-an-ssltls-certificate-from-a-certificate-authority-ca,https-from-web-hosts)
- [Enabling HTTPS on Your Servers | web.dev](https://web.dev/enabling-https-on-your-servers/)
- [Let's Encrypt Certificate Authority: Getting Started](https://letsencrypt.org/getting-started/)
- [certbox instructions for Apache on Ubuntu 20](https://certbot.eff.org/instructions?ws=apache&os=ubuntufocal)
- [certbot help](https://certbot.eff.org/pages/help)
- [How To Acquire a Let's Encrypt Certificate Using DNS Validation with acme-dns-certbot on Ubuntu 18.04 | Digital Ocean](https://www.digitalocean.com/community/tutorials/how-to-acquire-a-let-s-encrypt-certificate-using-dns-validation-with-acme-dns-certbot-on-ubuntu-18-04)
# CadastroDeContatos
This project is a task I received working at Esi Brasil as a Trainee. 
This application is useful to control the Contacts and User records, made using C# and EF Core, DataBase was used SQL Server. Now, let's see about the project:
<br />
<br />
1. To access the site, the user must be logged in to a session, 
if user forgot password, this can be recovered by option "Redefinir Senha/Reset Password". The new password is immediately sent to the user's e-mail.
- The admin user has all access over the app's features, the standard user has all access except for the Users page control.

![image](https://user-images.githubusercontent.com/91505101/179227395-8ca16a2a-5d83-49cb-86a4-e9cfbb1c884f.png)
<br />
<br />
<br />

2. On the contacts page, all records can be organized by six types of orders (id, name, cellphone, company name, state and registration date) as DataTable makes this feature available.
- On the same page you can choose the option to register a new contact, or edit/delete an existing contact.
- If you are adding a new contact, there are mandatory fields to fill in.
<br />

![image](https://user-images.githubusercontent.com/91505101/179283950-e8830a77-efcb-4b37-9d89-30ae8248372d.png)
<br />
<br />
<br />

3. The users page also contains a DataTable, but it provides different types of lookups (Id, Name, Email, Profile, Register Date).
- The admin user has all access over the app's features, the standard user has all access except for the Users page control. <br />

![image](https://user-images.githubusercontent.com/91505101/179245634-cb6930e5-659c-4d99-ba5d-1237e95bf021.png)
<br />
<br />
<br />

- When you add a new user, there are also mandatory fields and you can choose the profile between these two options: Admin or Standard. <br />

![image](https://user-images.githubusercontent.com/91505101/179245794-36783d9f-ed0e-45e1-a4f0-32067dac6494.png)
<br />
<br />
<br />

4. In reports, there is a drop-down menu with filter options. You can search by the name, company, state and registration date. <br />

![image](https://user-images.githubusercontent.com/91505101/179245246-04837eda-eb0b-4375-910f-1b21d7929d9c.png)
<br />
<br />
<br />

- To search by name, you can write the whole name or just letters, the system will bring up the records that contain these letters.<br />
 
![image](https://user-images.githubusercontent.com/91505101/179296396-cdf30233-d7b4-47d7-ba75-57a46d0452f1.png)
<br />
<br />
<br />

- To search by state, write the UF of contacts who are from the required state and then they will appear in the list. <br />


![image](https://user-images.githubusercontent.com/91505101/179296596-c8ccbde3-103e-4ceb-bd5c-9cd1e83c78e5.png)
<br />
<br />
<br />

- To search by registration date, select a minimum date and a maximun date, the list will show the contacts created between these dates. <br />

![image](https://user-images.githubusercontent.com/91505101/179300793-3fc84a10-76de-4758-beef-dc5bb2637078.png)


5. In Users, there is also a drop-down menu with directions to the pages: Add new contact, users list and change password. <br />

![image](https://user-images.githubusercontent.com/91505101/179245354-1d0829b9-467f-4287-8afb-248d8bf513d1.png)
<br />
<br />
<br />

6. In the Database, the user's password is encrypted for the privacy of all users. <br />

![image](https://user-images.githubusercontent.com/91505101/179301591-e393b925-ba6f-487f-884d-d1fa3e9623fd.png)

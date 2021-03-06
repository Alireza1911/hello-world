/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [custid]
      ,[companyname]
      ,[contactname]
      ,[contacttitle]
      ,[address]
      ,[city]
      ,[region]
      ,[postalcode]
      ,[country]
      ,[phone]
      ,[fax]
  FROM [TSQL2012].[Sales].[Customers]
  --نام و نام اتصال مشتری که در مکزیک و سه شماره اخر تلفن انها برابر 123 باشد 
  select companyname,contactname
  from Sales.Customers
  where country='mexico' and RIGHT( phone,3)='123'
  
 select max(country)
 from Sales.Customers
 --تعداد مشتری که در یک کشور هستند با نام ان کشور 
 select country,count(country)
 from Sales.Customers
 group by country
--بیشترین فراوانی را در سوال بالا بیابید
select MAX(a)from(select country,COUNT(country)as a from Sales.Customers group by country )as b
--کمترین فراوانی در سوال بالا
select min(a)from(select country,COUNT(country)as a from Sales.Customers group by country )as b
--نام و ادرس مشتریهایی که در یک شهر هستند
select distinct  (a.city) ,(a.address),(a.companyname)
from Sales.Customers as a
,
(select distinct city ,address,  companyname   
from Sales.Customers) as b
where a.city=b.city 
--نام مشتری هایی که در کشور المان باشند اما در شهر برلین نباشند
select companyname as CoName
from Sales.Customers
where country=N'germany'and city<>N'berlin'
--نام مشتری هایی که کانتکت تایتل یکسان دارند
select distinct (a.contacttitle),(a.companyname)
from Sales.Customers as a,
(select distinct contacttitle,companyname
from Sales.Customers
)as b
where a.contacttitle=b.contacttitle
--نام مشتری که ادرس انها با عدد شروع شود
select companyname,address
from Sales.Customers
where address like N'[1-9]%'
--maxرا در جدول میزنم فکر میکنم معیارش تعداد حروف است!
select MAX(country)
from Sales.Customers
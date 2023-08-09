create proc SP_SummaryOrders 
as
 select 
 (E.FirstName+''+E.LastName) 'Name',
 SUM(OD.Quantity) 'Quantity',
 DATEPART(YY,O.OrderDate) 'Year'
 from Employees E
 join Orders O on O.EmployeeID=E.EmployeeID
 join [Order Details] OD on OD.OrderID=O.OrderID
 Group by (E.FirstName+''+E.LastName), DATEPART(YY,O.OrderDate) 
 order by DATEPART(YY,O.OrderDate) 
select name from (
select managerid,count(managerid) as ct from employee group by managerId 
) as t join employee on t.managerid = employee.id where ct>4
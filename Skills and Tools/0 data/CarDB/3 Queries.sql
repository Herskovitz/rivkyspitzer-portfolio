
-- 5. Show a list of all the cars
select *
from Car c

-- 6. Show a list of cars ordered by year and then by model alphabetically.
select *
from Car c
order by c.MakeYear, c.Model
-- 7. Show the count for each make of the cars. Display the count and the make. Order by highest to lowest.
select MakeCount = count(*) ,c.Make
from Car c
group by c.Make
order by MakeCount

-- 8. Show the average year and price of the cars.
select AvgYear = avg(c.MakeYear), AvgPrice = avg(c.price)
from Car c

/* 9. The car market just went up and all luxury cars now cost an additional $5,000.
      Update the price of three cars that cost over $30,000.
*/
update c
set Price = c.Price + 5000
--select NewPrice = c.Price + 5000
from Car c
where c.price > 30000
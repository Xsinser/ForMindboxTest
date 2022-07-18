with 
leftPart (Id, Name) 
as 
(
select Id, Name 
    from Product
),

rightPart(IdProduct, Name)
as 
(
select IdProduct, Name 
    from Product_Categories 
        as pc 
    join Categories 
        as c 
    on pc.IdCategories = c.Id
)

select lp.Name as Product ,isnull(rp.Name,'No categories') as Categories 
    from leftPart
        as lp
    full join rightPart 
        as rp
    on rp.IdProduct = lp.Id

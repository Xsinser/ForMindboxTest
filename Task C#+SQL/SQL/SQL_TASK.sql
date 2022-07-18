with 
leftPart (Id, Name) 
as 
(
select Id, Name 
    from #produc
),

rightPart(idProduct, Name)
as 
(
select IdProduct, Name 
    from #produc_categories 
        as pc 
    join #categories 
        as c 
    on pc.idCategories = c.Id
)

select lp.Name as Product ,isnull(rp.Name,'No categories') as Categories 
    from leftPart
        as lp
    full join rightPart 
        as rp
    on rp.IdProduct = lp.Id
SELECT 
    i.Name,
    ISNULL(c.CategoryName, 'Без категории') AS CategoryName
FROM 
    Items as i
LEFT JOIN 
    ItemCategory as ic ON ic.ItemId = i.ItemId
LEFT JOIN 
    Category as c ON ic.CategoryId = c.CategoryId;
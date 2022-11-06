```
select P."Name", C."Name" from "Products" as P
left join "ManyToMany" MTM on P."Id" = MTM."ProductId"
left join "Category" C on C."Id" = MTM."CategoryId"

order by P."Id"
```

# MySQL_Bug_101236
This project is for reproducing the bug 101236.

Workthrough:
1. Create wpf project.
2. Install nuget MySql.Data.EntityFramework v8.0.22.
3. Create model by code first.
4. Execuate query to entity.
5. "MySqlException: Table 'schema.schema.table' doesn't exist" prompted.

Current solution:
1. Install nuget MySql.Data.EntityFramework v8.0.22.
2. Downgrade nuget to v8.0.21.
3. Since v8.0.21 has another bug that I can't create model through wizard, so I copy model created from v8.0.22.
4. Query works find.

# BlazorToDoLab
Blazor ToDo Lab 


```<div class="card shadow ">
    <div class="card-body">
        <h4 class="card-title">Wahnsinns ToDo</h4>
        <div class="row">
            <div class="col-md-12">
                <div class="main-todo-input-wrap">
                    <div class="main-todo-input fl-wrap">
                        <div class="input-group mb-3">
                            <input type="text" class="form-control" placeholder="Add Item">
                            <div class="input-group-append">
                                <button class="btn btn-success" type="button">
                                    +
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">
                        <div class="custom-control custom-checkbox">
                            <input type="checkbox" class="custom-control-input"
                                   id="switch1">
                            <label class="custom-control-label" for="switch1"></label>
                            <span>text</span>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
```

DBContext Model Klasse

```
public IConfiguration Configuration { get; }
public AufgabenContext(IConfiguration configuration, DbContextOptions<AufgabenContext> options) : base(options)
{
  Configuration = configuration;
}
public virtual DbSet<Aufgabe> Aufgaben { get; set; }
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
  if (!optionsBuilder.IsConfigured)
   {
    optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ToDoDatabase"));
    }
}
protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
  base.OnModelCreating(modelBuilder);
 }
}
```


    
Connection String appsettings.json
```
"ConnectionStrings": {
    "ToDoDatabase":  "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\\pfad\\app_data\\aufgaben.mdf;database=aufgaben;Integrated Security=True;"


  },
```

weiteres
```
code
```



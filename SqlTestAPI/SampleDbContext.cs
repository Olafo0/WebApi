using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SqlTestAPI.DbModels;

namespace SqlTestAPI;

public partial class SampleDbContext : DbContext
{
    public SampleDbContext()
    {
    }

    public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AntarcticPopulation> AntarcticPopulations { get; set; }

    public virtual DbSet<AntarcticSpecy> AntarcticSpecies { get; set; }

    public virtual DbSet<ArizonaSighting> ArizonaSightings { get; set; }

    public virtual DbSet<CaliforniaSighting> CaliforniaSightings { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<FloridaSighting> FloridaSightings { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=SampleDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AntarcticPopulation>(entity =>
        {
            entity.HasKey(e => new { e.SpeciesId, e.Locality, e.DateOfCount }).HasName("pk_antarctic_populations");

            entity.ToTable("antarctic_populations", "bird");

            entity.HasIndex(e => e.DateOfCount, "ix_antarctic_popdate_of_count");

            entity.Property(e => e.SpeciesId).HasColumnName("species_id");
            entity.Property(e => e.Locality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locality");
            entity.Property(e => e.DateOfCount)
                .HasColumnType("date")
                .HasColumnName("date_of_count");
            entity.Property(e => e.PopulationCount).HasColumnName("population_count");

            entity.HasOne(d => d.Species).WithMany(p => p.AntarcticPopulations)
                .HasForeignKey(d => d.SpeciesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_antarctic_populations_species");
        });

        modelBuilder.Entity<AntarcticSpecy>(entity =>
        {
            entity.HasKey(e => e.SpeciesId).HasName("pk_antarctic_species");

            entity.ToTable("antarctic_species", "bird");

            entity.HasIndex(e => e.ScientificName, "UK_ix_antarctic_species").IsUnique();

            entity.Property(e => e.SpeciesId).HasColumnName("species_id");
            entity.Property(e => e.CommonName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("common_name");
            entity.Property(e => e.ScientificName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scientific_name");
        });

        modelBuilder.Entity<ArizonaSighting>(entity =>
        {
            entity.HasKey(e => e.SightingId).HasName("pk_arizona_sightings");

            entity.ToTable("arizona_sightings", "bird");

            entity.Property(e => e.SightingId).HasColumnName("sighting_id");
            entity.Property(e => e.CommonName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("common_name");
            entity.Property(e => e.ScientificName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("scientific_name");
            entity.Property(e => e.SightingDate)
                .HasColumnType("date")
                .HasColumnName("sighting_date");
            entity.Property(e => e.SightingLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sighting_location");
        });

        modelBuilder.Entity<CaliforniaSighting>(entity =>
        {
            entity.HasKey(e => e.SightingId).HasName("pk_california_sightings");

            entity.ToTable("california_sightings", "bird");

            entity.Property(e => e.SightingId).HasColumnName("sighting_id");
            entity.Property(e => e.CommonName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("common_name");
            entity.Property(e => e.LocationOfSighting)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location_of_sighting");
            entity.Property(e => e.ScientificName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("scientific_name");
            entity.Property(e => e.SightingDate)
                .HasColumnType("date")
                .HasColumnName("sighting_date");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("pk_countries");

            entity.ToTable("countries", "hcm");

            entity.HasIndex(e => e.CountryName, "uk_countries_country_name").IsUnique();

            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_name");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("pk_customers_customer_id");

            entity.ToTable("customers", "oes");

            entity.HasIndex(e => e.City, "ix_customers_city");

            entity.HasIndex(e => e.CountryId, "ix_customers_country_id");

            entity.HasIndex(e => e.StateProvince, "ix_customers_state_province");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.LoyaltyCardIssued).HasColumnName("loyalty_card_issued");
            entity.Property(e => e.Phone)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.StateProvince)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("state_province");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street_address");

            entity.HasOne(d => d.Country).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_customers_countries");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("pk_departments");

            entity.ToTable("departments", "hcm");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("department_name");
            entity.Property(e => e.LocationId).HasColumnName("location_id");

            entity.HasOne(d => d.Location).WithMany(p => p.Departments)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_departments_locations");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("pk_employees");

            entity.ToTable("employees", "hcm");

            entity.HasIndex(e => e.CountryId, "ix_employees_country_id");

            entity.HasIndex(e => e.LastName, "ix_employees_lastname");

            entity.HasIndex(e => e.ManagerId, "ix_employees_manager_id");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.BirthDate)
                .HasColumnType("date")
                .HasColumnName("birth_date");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.HireDate)
                .HasColumnType("date")
                .HasColumnName("hire_date");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.Salary)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("salary");
            entity.Property(e => e.StateProvince)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("state_province");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street_address");

            entity.HasOne(d => d.Country).WithMany(p => p.Employees)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employees_countries");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("fk_employees_departments");

            entity.HasOne(d => d.Job).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employees_jobs");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("fk_employees_manager_id");
        });

        modelBuilder.Entity<FloridaSighting>(entity =>
        {
            entity.HasKey(e => e.ObservationId).HasName("pk_florida_sightings");

            entity.ToTable("florida_sightings", "bird");

            entity.Property(e => e.ObservationId).HasColumnName("observation_id");
            entity.Property(e => e.Locality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locality");
            entity.Property(e => e.ScientificName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scientific_name");
            entity.Property(e => e.SightingDatetime).HasColumnName("sighting_datetime");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.WarehouseId }).HasName("pk_inventories");

            entity.ToTable("inventories", "oes");

            entity.HasIndex(e => e.ProductId, "ix_inventories_product_id");

            entity.HasIndex(e => e.WarehouseId, "ix_inventories_warehouse_id");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            entity.Property(e => e.QuantityOnHand).HasColumnName("quantity_on_hand");

            entity.HasOne(d => d.Product).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_inventories_products");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_inventories_warehouses");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("pk_jobs");

            entity.ToTable("jobs", "hcm");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("job_title");
            entity.Property(e => e.MaxSalary)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("max_salary");
            entity.Property(e => e.MinSalary)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("min_salary");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("pk_locations");

            entity.ToTable("locations", "hcm");

            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.StateProvince)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("state_province");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street_address");

            entity.HasOne(d => d.Country).WithMany(p => p.Locations)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_locations_countries");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("pk_orders_order_id");

            entity.ToTable("orders", "oes");

            entity.HasIndex(e => e.CustomerId, "ix_orders_customer_id");

            entity.HasIndex(e => e.EmployeeId, "ix_orders_employee_id");

            entity.HasIndex(e => e.OrderDate, "ix_orders_order_date");

            entity.HasIndex(e => e.ShipperId, "ix_orders_shipper_id");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.FreightCost)
                .HasColumnType("numeric(19, 4)")
                .HasColumnName("freight_cost");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("order_date");
            entity.Property(e => e.ShippedDate)
                .HasColumnType("date")
                .HasColumnName("shipped_date");
            entity.Property(e => e.ShipperId).HasColumnName("shipper_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orders_customer_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("fk_orders_employees");

            entity.HasOne(d => d.Shipper).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShipperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orders_shippers");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("pk_order_items");

            entity.ToTable("order_items", "oes");

            entity.HasIndex(e => e.OrderId, "ix_order_items_order_id");

            entity.HasIndex(e => e.ProductId, "ix_order_items_product_id");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Discount)
                .HasColumnType("numeric(4, 3)")
                .HasColumnName("discount");
            entity.Property(e => e.Quantity)
                .HasDefaultValueSql("((1))")
                .HasColumnName("quantity");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("numeric(19, 4)")
                .HasColumnName("unit_price");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_items_orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_items_products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("pk_products_product_id");

            entity.ToTable("products", "oes");

            entity.HasIndex(e => e.CategoryId, "ix_products_category_id");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Discontinued).HasColumnName("discontinued");
            entity.Property(e => e.ListPrice)
                .HasColumnType("numeric(19, 4)")
                .HasColumnName("list_price");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("product_name");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_products_product_categories");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("pk_product_categories_cat_id");

            entity.ToTable("product_categories", "oes");

            entity.HasIndex(e => e.CategoryName, "ix_category_name");

            entity.HasIndex(e => e.CategoryName, "uk_product_categories_cat_name").IsUnique();

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CategoryDescription)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("category_description");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("category_name");
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.HasKey(e => e.ShipperId).HasName("pk_shippers_shipper_id");

            entity.ToTable("shippers", "oes");

            entity.Property(e => e.ShipperId).HasColumnName("shipper_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("pk_warehouses_warehouse_id");

            entity.ToTable("warehouses", "oes");

            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("warehouse_name");

            entity.HasOne(d => d.Location).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("fk_warehouses_locations");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

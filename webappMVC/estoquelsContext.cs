using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace webappMVC
{
    public partial class estoquelsContext : DbContext
    {
        public estoquelsContext()
        {
        }

        public estoquelsContext(DbContextOptions<estoquelsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Caixa> Caixas { get; set; }
        public virtual DbSet<Caixabrir> Caixabrirs { get; set; }
        public virtual DbSet<Caixafecha> Caixafechas { get; set; }
        public virtual DbSet<Caixamov> Caixamovs { get; set; }
        public virtual DbSet<Caixasaidum> Caixasaida { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Colaborador> Colaboradors { get; set; }
        public virtual DbSet<Conveniado> Conveniados { get; set; }
        public virtual DbSet<Convenio> Convenios { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Estoque> Estoques { get; set; }
        public virtual DbSet<Estorno> Estornos { get; set; }
        public virtual DbSet<Fabricante> Fabricantes { get; set; }
        public virtual DbSet<Fornecedor> Fornecedors { get; set; }
        public virtual DbSet<Grupo> Grupos { get; set; }
        public virtual DbSet<Locacaoitem> Locacaoitems { get; set; }
        public virtual DbSet<Materiaisexit> Materiaisexits { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Pgto> Pgtos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Produtoent> Produtoents { get; set; }
        public virtual DbSet<Produtonfiscal> Produtonfiscals { get; set; }
        public virtual DbSet<Produtontvenc> Produtontvencs { get; set; }
        public virtual DbSet<Setor> Setors { get; set; }
        public virtual DbSet<Unidad> Unidads { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vendaconvenio> Vendaconvenios { get; set; }
        public virtual DbSet<Vendaitem> Vendaitems { get; set; }
        public virtual DbSet<Vendapedido> Vendapedidos { get; set; }
        public virtual DbSet<Vendedor> Vendedors { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<ViewReportPedido> ViewReportPedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=TI02\\sqlexpress;Initial Catalog=estoquels;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Caixa>(entity =>
            {
                entity.HasKey(e => e.Codcaixa)
                    .HasName("PK_caixa");

                entity.ToTable("CAIXA");

                entity.Property(e => e.Codcaixa).HasColumnName("codcaixa");

                entity.Property(e => e.Codabert).HasColumnName("codabert");

                entity.Property(e => e.Codoper).HasColumnName("codoper");

                entity.Property(e => e.Dthabertura)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dthabertura")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dthfechamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dthfechamento");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodabertNavigation)
                    .WithMany(p => p.Caixas)
                    .HasForeignKey(d => d.Codabert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_caixa_caixabrir");

                entity.HasOne(d => d.CodoperNavigation)
                    .WithMany(p => p.Caixas)
                    .HasForeignKey(d => d.Codoper)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_caixa_usuario");
            });

            modelBuilder.Entity<Caixabrir>(entity =>
            {
                entity.HasKey(e => e.Codabert)
                    .HasName("PK_caixabrir");

                entity.ToTable("CAIXABRIR");

                entity.Property(e => e.Codabert).HasColumnName("codabert");

                entity.Property(e => e.Codoper).HasColumnName("codoper");

                entity.Property(e => e.Dthabertura)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dthabertura");

                entity.Property(e => e.Saldoinicial)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("saldoinicial");
            });

            modelBuilder.Entity<Caixafecha>(entity =>
            {
                entity.HasKey(e => e.Codfech)
                    .HasName("PK_caixafecha");

                entity.ToTable("CAIXAFECHA");

                entity.Property(e => e.Codfech).HasColumnName("codfech");

                entity.Property(e => e.Codcaixa).HasColumnName("codcaixa");

                entity.Property(e => e.Codoper).HasColumnName("codoper");

                entity.Property(e => e.Codpg).HasColumnName("codpg");

                entity.Property(e => e.Dthfechamento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dthfechamento");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('F')")
                    .IsFixedLength(true);

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.CodcaixaNavigation)
                    .WithMany(p => p.Caixafechas)
                    .HasForeignKey(d => d.Codcaixa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_caixafecha_caixa");
            });

            modelBuilder.Entity<Caixamov>(entity =>
            {
                entity.HasKey(e => e.Codmov)
                    .HasName("PK_caixamov_1");

                entity.ToTable("CAIXAMOV");

                entity.Property(e => e.Codmov).HasColumnName("codmov");

                entity.Property(e => e.Codcaixa).HasColumnName("codcaixa");

                entity.Property(e => e.Codpg).HasColumnName("codpg");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.Vlnota)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("vlnota");
            });

            modelBuilder.Entity<Caixasaidum>(entity =>
            {
                entity.HasKey(e => e.Codsai)
                    .HasName("PK_caixamov");

                entity.ToTable("CAIXASAIDA");

                entity.Property(e => e.Codsai).HasColumnName("codsai");

                entity.Property(e => e.Codcaixa).HasColumnName("codcaixa");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("data");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("motivo")
                    .IsFixedLength(true);

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.CodcaixaNavigation)
                    .WithMany(p => p.Caixasaida)
                    .HasForeignKey(d => d.Codcaixa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_caixamov_caixa");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.Codcargo)
                    .HasName("PK_cargos");

                entity.ToTable("CARGO");

                entity.Property(e => e.Codcargo).HasColumnName("codcargo");

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtatualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtatualizacao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.Idcid)
                    .HasName("PK_Cidade");

                entity.ToTable("CIDADE");

                entity.Property(e => e.Idcid)
                    .ValueGeneratedNever()
                    .HasColumnName("idcid");

                entity.Property(e => e.Cidade1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Codcli);

                entity.ToTable("CLIENTE");

                entity.Property(e => e.Codcli)
                    .ValueGeneratedNever()
                    .HasColumnName("codcli");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cep")
                    .IsFixedLength(true);

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cidade")
                    .HasDefaultValueSql("('MANAUS')");

                entity.Property(e => e.ClassificacaoId)
                    .HasMaxLength(25)
                    .HasColumnName("classificacao_id");

                entity.Property(e => e.CodEmp).HasColumnName("cod_emp");

                entity.Property(e => e.Codsetor).HasColumnName("codsetor");

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.Dtatualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtatualizacao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Identificador)
                    .HasMaxLength(25)
                    .HasColumnName("identificador");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(25)
                    .HasColumnName("matricula")
                    .IsFixedLength(true);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("referencia");

                entity.Property(e => e.Rua)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rua");

                entity.Property(e => e.Telef)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telef");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf")
                    .HasDefaultValueSql("('AM')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Colaborador>(entity =>
            {
                entity.HasKey(e => e.Idcolab);

                entity.ToTable("COLABORADOR");

                entity.Property(e => e.Idcolab).HasColumnName("idcolab");

                entity.Property(e => e.Aceite).HasColumnName("aceite");

                entity.Property(e => e.Datacad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("datacad");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(20)
                    .HasColumnName("empresa")
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Identificador)
                    .HasMaxLength(15)
                    .HasColumnName("identificador")
                    .IsFixedLength(true);

                entity.Property(e => e.Nome)
                    .HasMaxLength(30)
                    .HasColumnName("nome")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Conveniado>(entity =>
            {
                entity.HasKey(e => e.Idcon)
                    .HasName("PK__convenia__D24C16766A30C649");

                entity.ToTable("CONVENIADO");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Codempre).HasColumnName("codempre");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.Depende)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("depende")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Dtcompra)
                    .HasColumnType("date")
                    .HasColumnName("dtcompra");

                entity.Property(e => e.Matric)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("matric");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rg")
                    .IsFixedLength(true);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefone")
                    .IsFixedLength(true);

                entity.Property(e => e.Vrcompra)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vrcompra");

                entity.Property(e => e.Vrlimite)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vrlimite");

                entity.HasOne(d => d.CodempreNavigation)
                    .WithMany(p => p.Conveniados)
                    .HasForeignKey(d => d.Codempre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_conveniado_convenio");
            });

            modelBuilder.Entity<Convenio>(entity =>
            {
                entity.HasKey(e => e.Codconvenio)
                    .HasName("PK_convenio");

                entity.ToTable("CONVENIO");

                entity.Property(e => e.Codconvenio).HasColumnName("codconvenio");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cep");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Desconto)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("desconto");

                entity.Property(e => e.Diafecha).HasColumnName("diafecha");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Fone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fone");

                entity.Property(e => e.Ie)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ie");

                entity.Property(e => e.Razao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razao");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("referencia");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.CodEmp)
                    .HasName("PK_empresa");

                entity.ToTable("EMPRESA");

                entity.Property(e => e.CodEmp).HasColumnName("cod_emp");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("bairro")
                    .IsFixedLength(true);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cep")
                    .IsFixedLength(true);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cidade")
                    .IsFixedLength(true);

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ")
                    .IsFixedLength(true);

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.Dtatualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtatualizacao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL")
                    .IsFixedLength(true);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("endereco")
                    .IsFixedLength(true);

                entity.Property(e => e.Inscricao)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO")
                    .IsFixedLength(true);

                entity.Property(e => e.Logomarca)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("logomarca")
                    .IsFixedLength(true);

                entity.Property(e => e.Resp)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("resp")
                    .IsFixedLength(true);

                entity.Property(e => e.Rsocial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RSOCIAL")
                    .IsFixedLength(true);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sistema")
                    .IsFixedLength(true);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("ESTADO");

                entity.Property(e => e.EstadoId).ValueGeneratedNever();

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasKey(e => e.Codestoque);

                entity.ToTable("ESTOQUE");

                entity.Property(e => e.Codestoque).HasColumnName("codestoque");

                entity.Property(e => e.Codempre).HasColumnName("codempre");

                entity.Property(e => e.Codprod).HasColumnName("codprod");

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.Dtatualiza)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtatualiza");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Estoque1)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("estoque")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Maximo)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("maximo");

                entity.Property(e => e.Minimo)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("minimo");

                entity.HasOne(d => d.CodprodNavigation)
                    .WithMany(p => p.Estoques)
                    .HasForeignKey(d => d.Codprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESTOQUE_PRODUTOS");
            });

            modelBuilder.Entity<Estorno>(entity =>
            {
                entity.HasKey(e => e.Codestorno);

                entity.ToTable("ESTORNO");

                entity.Property(e => e.Codestorno)
                    .ValueGeneratedNever()
                    .HasColumnName("codestorno");

                entity.Property(e => e.Codprod).HasColumnName("codprod");

                entity.Property(e => e.Codvenda).HasColumnName("codvenda");

                entity.Property(e => e.Qtd).HasColumnName("qtd");
            });

            modelBuilder.Entity<Fabricante>(entity =>
            {
                entity.HasKey(e => e.Codfab)
                    .HasName("PK_fabricante");

                entity.ToTable("FABRICANTE");

                entity.Property(e => e.Codfab).HasColumnName("codfab");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.Codforne)
                    .HasName("PK_fornecedor");

                entity.ToTable("FORNECEDOR");

                entity.Property(e => e.Codforne).HasColumnName("codforne");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("bairro")
                    .IsFixedLength(true);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("cep")
                    .IsFixedLength(true);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cidade")
                    .IsFixedLength(true);

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj")
                    .IsFixedLength(true);

                entity.Property(e => e.Contato)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contato")
                    .IsFixedLength(true);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Fantasia)
                    .HasMaxLength(40)
                    .HasColumnName("fantasia")
                    .IsFixedLength(true);

                entity.Property(e => e.Inscricao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inscricao")
                    .IsFixedLength(true);

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("rua")
                    .IsFixedLength(true);

                entity.Property(e => e.Telef)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telef")
                    .IsFixedLength(true);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.Codgp)
                    .HasName("PK_amgrupos");

                entity.ToTable("GRUPO");

                entity.Property(e => e.Codgp).HasColumnName("codgp");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");
            });

            modelBuilder.Entity<Locacaoitem>(entity =>
            {
                entity.HasKey(e => e.Coditem);

                entity.ToTable("LOCACAOITEM");

                entity.Property(e => e.Coditem).HasColumnName("coditem");

                entity.Property(e => e.Codcliente).HasColumnName("codcliente");

                entity.Property(e => e.Codempr).HasColumnName("codempr");

                entity.Property(e => e.Codprod).HasColumnName("codprod");

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.Datadev)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("datadev");

                entity.Property(e => e.Dataloc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dataloc");

                entity.Property(e => e.Dtatualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtatualizacao");

                entity.Property(e => e.Dtdevolvido)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtdevolvido");

                entity.Property(e => e.Identificador)
                    .HasMaxLength(20)
                    .HasColumnName("identificador");

                entity.Property(e => e.Nomedev)
                    .HasMaxLength(25)
                    .HasColumnName("nomedev");

                entity.Property(e => e.Npedido).HasColumnName("npedido");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("unidad")
                    .IsFixedLength(true);

                entity.Property(e => e.Valortotal)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valortotal");
            });

            modelBuilder.Entity<Materiaisexit>(entity =>
            {
                entity.HasKey(e => e.Coditem);

                entity.ToTable("MATERIAISEXIT");

                entity.Property(e => e.Coditem).HasColumnName("coditem");

                entity.Property(e => e.Codcliente).HasColumnName("codcliente");

                entity.Property(e => e.Codprod).HasColumnName("codprod");

                entity.Property(e => e.Codsetor).HasColumnName("codsetor");

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.Dtsaida)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtsaida");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Identificador)
                    .HasMaxLength(15)
                    .HasColumnName("identificador")
                    .IsFixedLength(true);

                entity.Property(e => e.Npedido).HasColumnName("npedido");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("qtd");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(2)
                    .HasColumnName("unidad")
                    .IsFixedLength(true);

                entity.Property(e => e.Valortotal)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valortotal");

                entity.HasOne(d => d.CodprodNavigation)
                    .WithMany(p => p.Materiaisexits)
                    .HasForeignKey(d => d.Codprod)
                    .HasConstraintName("FK_MATERIAISEXIT_PRODUTOS");

                entity.HasOne(d => d.CodsetorNavigation)
                    .WithMany(p => p.Materiaisexits)
                    .HasForeignKey(d => d.Codsetor)
                    .HasConstraintName("FK_MATERIAISEXIT_SETOR");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("PEDIDO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Npedido).HasColumnName("npedido");
            });

            modelBuilder.Entity<Pgto>(entity =>
            {
                entity.HasKey(e => e.Codpg)
                    .HasName("PK_pgto");

                entity.ToTable("PGTO");

                entity.Property(e => e.Codpg).HasColumnName("codpg");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Codprod)
                    .HasName("PK_produtos");

                entity.ToTable("PRODUTOS");

                entity.Property(e => e.Codprod).HasColumnName("codprod");

                entity.Property(e => e.Codbarra)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("codbarra");

                entity.Property(e => e.Codfab).HasColumnName("codfab");

                entity.Property(e => e.Codgp).HasColumnName("codgp");

                entity.Property(e => e.Codunid).HasColumnName("codunid");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("date")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Estoque)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("estoque")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Patrimonio)
                    .HasMaxLength(15)
                    .HasColumnName("patrimonio")
                    .IsFixedLength(true);

                entity.Property(e => e.Precocon)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precocon");

                entity.Property(e => e.Precocus)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precocus");

                entity.Property(e => e.Saldo)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("saldo");

                entity.HasOne(d => d.CodfabNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.Codfab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_produtos_fabricante");

                entity.HasOne(d => d.CodgpNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.Codgp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_produtos_grupo");

                entity.HasOne(d => d.Codun)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.Codunid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_produtos_unidad");
            });

            modelBuilder.Entity<Produtoent>(entity =>
            {
                entity.HasKey(e => e.Codent)
                    .HasName("PK_ENTPRODUTO");

                entity.ToTable("PRODUTOENT");

                entity.Property(e => e.Codent).HasColumnName("CODENT");

                entity.Property(e => e.Ckntfiscal).HasColumnName("CKNTFISCAL");

                entity.Property(e => e.Codempre).HasColumnName("CODEMPRE");

                entity.Property(e => e.Codprod).HasColumnName("CODPROD");

                entity.Property(e => e.Coduser).HasColumnName("CODUSER");

                entity.Property(e => e.Dtentrada)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DTENTRADA");

                entity.Property(e => e.Idnotafiscal).HasColumnName("idnotafiscal");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("QTD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valorprod)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("VALORPROD")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Produtonfiscal>(entity =>
            {
                entity.HasKey(e => e.Idnotafiscal);

                entity.ToTable("PRODUTONFISCAL");

                entity.Property(e => e.Idnotafiscal).HasColumnName("idnotafiscal");

                entity.Property(e => e.Chaveacesso)
                    .HasMaxLength(30)
                    .HasColumnName("chaveacesso")
                    .IsFixedLength(true);

                entity.Property(e => e.Codfornecedor).HasColumnName("codfornecedor");

                entity.Property(e => e.Dtcadastro)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcadastro");

                entity.Property(e => e.Emissao)
                    .HasColumnType("date")
                    .HasColumnName("emissao");

                entity.Property(e => e.Ntfiscal)
                    .HasMaxLength(30)
                    .HasColumnName("ntfiscal")
                    .IsFixedLength(true);

                entity.Property(e => e.Valornota)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valornota");
            });

            modelBuilder.Entity<Produtontvenc>(entity =>
            {
                entity.HasKey(e => e.Idvenc);

                entity.ToTable("PRODUTONTVENC");

                entity.Property(e => e.Idvenc).HasColumnName("idvenc");

                entity.Property(e => e.Data)
                    .HasMaxLength(10)
                    .HasColumnName("data")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Idnotafiscal).HasColumnName("idnotafiscal");

                entity.Property(e => e.Vlparcela)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("vlparcela");

                entity.HasOne(d => d.IdnotafiscalNavigation)
                    .WithMany(p => p.Produtontvencs)
                    .HasForeignKey(d => d.Idnotafiscal)
                    .HasConstraintName("FK_PRODUTONTVENC_PRODUTONFISCAL");
            });

            modelBuilder.Entity<Setor>(entity =>
            {
                entity.HasKey(e => e.Codsetor);

                entity.ToTable("SETOR");

                entity.Property(e => e.Codsetor).HasColumnName("codsetor");

                entity.Property(e => e.Codempr).HasColumnName("codempr");

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("descricao")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtatualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtatualizacao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Observe)
                    .HasMaxLength(50)
                    .HasColumnName("observe")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Unidad>(entity =>
            {
                entity.HasKey(e => e.Codunid)
                    .HasName("PK_unidad");

                entity.ToTable("UNIDAD");

                entity.Property(e => e.Codunid).HasColumnName("codunid");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sigla");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Coduser)
                    .HasName("PK_usuario");

                entity.ToTable("USUARIO");

                entity.Property(e => e.Coduser).HasColumnName("coduser");

                entity.Property(e => e.CodEmpre).HasColumnName("cod_empre");

                entity.Property(e => e.Codcargo).HasColumnName("codcargo");

                entity.Property(e => e.CompleteName)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Dtatualizacao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtatualizacao");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Vendaconvenio>(entity =>
            {
                entity.HasKey(e => e.Codcon);

                entity.ToTable("VENDACONVENIO");

                entity.Property(e => e.Codcon).HasColumnName("codcon");

                entity.Property(e => e.Codped).HasColumnName("codped");

                entity.Property(e => e.Dtvenda)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtvenda");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vltotal");

                entity.HasOne(d => d.CodpedNavigation)
                    .WithMany(p => p.Vendaconvenios)
                    .HasForeignKey(d => d.Codped)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_vendaConvenio_VendaPedido");

                entity.HasOne(d => d.IdconNavigation)
                    .WithMany(p => p.Vendaconvenios)
                    .HasForeignKey(d => d.Idcon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_vendaConvenio_conveniado");
            });

            modelBuilder.Entity<Vendaitem>(entity =>
            {
                entity.HasKey(e => e.Coditem)
                    .HasName("PK_VendaItem_1");

                entity.ToTable("VENDAITEM");

                entity.Property(e => e.Coditem).HasColumnName("coditem");

                entity.Property(e => e.Codped).HasColumnName("codped");

                entity.Property(e => e.Codpro).HasColumnName("codpro");

                entity.Property(e => e.Descont)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("descont");

                entity.Property(e => e.Dtvenda)
                    .HasColumnType("date")
                    .HasColumnName("dtvenda");

                entity.Property(e => e.Qtdven)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("qtdven");

                entity.Property(e => e.Unid)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("unid")
                    .IsFixedLength(true);

                entity.Property(e => e.Vltotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vltotal");

                entity.HasOne(d => d.CodpedNavigation)
                    .WithMany(p => p.Vendaitems)
                    .HasForeignKey(d => d.Codped)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendaItem_VendaPedido");

                entity.HasOne(d => d.CodproNavigation)
                    .WithMany(p => p.Vendaitems)
                    .HasForeignKey(d => d.Codpro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsVenda_produtos");
            });

            modelBuilder.Entity<Vendapedido>(entity =>
            {
                entity.HasKey(e => e.Codped)
                    .HasName("PK_VendaPedido_1");

                entity.ToTable("VENDAPEDIDO");

                entity.Property(e => e.Codped).HasColumnName("codped");

                entity.Property(e => e.Codcaixa).HasColumnName("codcaixa");

                entity.Property(e => e.Codpg).HasColumnName("codpg");

                entity.Property(e => e.Codven).HasColumnName("codven");

                entity.Property(e => e.Dtped)
                    .HasColumnType("date")
                    .HasColumnName("dtped");

                entity.Property(e => e.Vlnota)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vlnota");

                entity.HasOne(d => d.CodpgNavigation)
                    .WithMany(p => p.Vendapedidos)
                    .HasForeignKey(d => d.Codpg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendaPedido_pgto");

                entity.HasOne(d => d.CodvenNavigation)
                    .WithMany(p => p.Vendapedidos)
                    .HasForeignKey(d => d.Codven)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendaPedido_vendedor");
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(e => e.Codven)
                    .HasName("PK_vendedo");

                entity.ToTable("VENDEDOR");

                entity.Property(e => e.Codven).HasColumnName("codven");

                entity.Property(e => e.Dtcad)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtcad");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sobrenome");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.Codped).HasColumnName("codped");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Dtped)
                    .HasColumnType("date")
                    .HasColumnName("dtped");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Vlnota)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vlnota");
            });

            modelBuilder.Entity<ViewReportPedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewReportPedido");

                entity.Property(e => e.Codped).HasColumnName("codped");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Vlnota)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vlnota");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

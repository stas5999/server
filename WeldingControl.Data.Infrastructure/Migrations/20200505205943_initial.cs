using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WeldingControl.Data.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:citext", ",,");

            migrationBuilder.CreateTable(
                name: "additional_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: false),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_additional_materials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "connection_forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'4', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: false),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_connection_forms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filler_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'9', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: true),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_filler_materials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "main_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'4', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    group = table.Column<int>(type: "Integer", nullable: false),
                    sub_group = table.Column<int>(type: "Integer", nullable: false),
                    description = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_main_materials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "organizations",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'3', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_organizations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "recorders",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    identifier = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_recorders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shielding_gases",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: false),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_shielding_gases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "weld_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'3', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: false),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weld_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "welding_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: false),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_materials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "welding_processes",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'12', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "Varchar", nullable: false),
                    description = table.Column<string>(type: "Varchar", nullable: true),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_processes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "welding_techniques",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'8', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: false),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_techniques", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "welding_positions",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'13', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    abbreviation = table.Column<string>(type: "Varchar", nullable: false),
                    code = table.Column<string>(type: "Varchar", nullable: true),
                    description = table.Column<string>(type: "Varchar", nullable: false),
                    connection_form_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_positions", x => x.id);
                    table.ForeignKey(
                        name: "fk_welding_positions_connection_forms_connection_form_id",
                        column: x => x.connection_form_id,
                        principalTable: "connection_forms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'5', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    position = table.Column<int>(type: "Integer", nullable: false),
                    employment_date = table.Column<DateTime>(type: "Date", nullable: false),
                    user_name = table.Column<string>(type: "Varchar", maxLength: 30, nullable: false),
                    first_name = table.Column<string>(type: "Varchar", nullable: false),
                    last_name = table.Column<string>(type: "Varchar", nullable: false),
                    middle_name = table.Column<string>(type: "Varchar", nullable: false),
                    birth_date = table.Column<DateTime>(type: "Date", nullable: false),
                    stamp = table.Column<string>(type: "Varchar", nullable: false),
                    identification = table.Column<string>(type: "Varchar", nullable: false),
                    organization_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employees", x => x.id);
                    table.ForeignKey(
                        name: "fk_employees_organizations_organization_id",
                        column: x => x.organization_id,
                        principalTable: "organizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'3', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "Varchar", nullable: false),
                    description = table.Column<string>(type: "Varchar", nullable: true),
                    creation_date = table.Column<string>(type: "Varchar", nullable: false),
                    organization_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.id);
                    table.ForeignKey(
                        name: "fk_products_organizations_organization_id",
                        column: x => x.organization_id,
                        principalTable: "organizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "welding_instructions",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    creation_date = table.Column<DateTime>(type: "Date", nullable: false),
                    organization_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_instructions", x => x.id);
                    table.ForeignKey(
                        name: "fk_welding_instructions_organizations_organization_id",
                        column: x => x.organization_id,
                        principalTable: "organizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "welding_machines",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    identification = table.Column<string>(type: "Varchar", nullable: false),
                    organization_id = table.Column<int>(type: "Integer", nullable: false),
                    recorder_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_machines", x => x.id);
                    table.ForeignKey(
                        name: "fk_welding_machines_organizations_organization_id",
                        column: x => x.organization_id,
                        principalTable: "organizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_welding_machines_recorders_recorder_id",
                        column: x => x.recorder_id,
                        principalTable: "recorders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificates",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'4', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    issue_date = table.Column<DateTime>(type: "Date", nullable: false),
                    expires_date = table.Column<DateTime>(type: "Date", nullable: false),
                    employee_id = table.Column<int>(type: "Integer", nullable: false),
                    thickness_min = table.Column<double>(nullable: true),
                    thickness_max = table.Column<double>(nullable: true),
                    pipe_outer_diameter_min = table.Column<double>(nullable: true),
                    pipe_outer_diameter_max = table.Column<double>(nullable: true),
                    decision = table.Column<string>(type: "Varchar", maxLength: 10000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificates", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificates_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "welds",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    product_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welds", x => x.id);
                    table.ForeignKey(
                        name: "fk_welds_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weld_params",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    current_min = table.Column<double>(nullable: true),
                    current_max = table.Column<double>(nullable: true),
                    thickness_min = table.Column<double>(nullable: true),
                    thickness_max = table.Column<double>(nullable: true),
                    pipe_outer_diameter_min = table.Column<double>(nullable: true),
                    pipe_outer_diameter_max = table.Column<double>(nullable: true),
                    welding_process_id = table.Column<int>(type: "Integer", nullable: true),
                    connection_form_id = table.Column<int>(type: "Integer", nullable: true),
                    weld_type_id = table.Column<int>(type: "Integer", nullable: true),
                    main_material_id = table.Column<int>(type: "Integer", nullable: true),
                    filler_material_id = table.Column<int>(type: "Integer", nullable: true),
                    shielding_gas_id = table.Column<int>(type: "Integer", nullable: true),
                    welding_material_id = table.Column<int>(type: "Integer", nullable: true),
                    additional_material_id = table.Column<int>(type: "Integer", nullable: true),
                    welding_position_id = table.Column<int>(type: "Integer", nullable: true),
                    welding_instruction_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_technique_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weld_params", x => x.id);
                    table.ForeignKey(
                        name: "fk_weld_params_additional_materials_additional_material_id",
                        column: x => x.additional_material_id,
                        principalTable: "additional_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_connection_forms_connection_form_id",
                        column: x => x.connection_form_id,
                        principalTable: "connection_forms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_filler_materials_filler_material_id",
                        column: x => x.filler_material_id,
                        principalTable: "filler_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_main_materials_main_material_id",
                        column: x => x.main_material_id,
                        principalTable: "main_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_shielding_gases_shielding_gas_id",
                        column: x => x.shielding_gas_id,
                        principalTable: "shielding_gases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_weld_types_weld_type_id",
                        column: x => x.weld_type_id,
                        principalTable: "weld_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_welding_instructions_welding_instruction_id",
                        column: x => x.welding_instruction_id,
                        principalTable: "welding_instructions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weld_params_welding_materials_welding_material_id",
                        column: x => x.welding_material_id,
                        principalTable: "welding_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_welding_positions_welding_position_id",
                        column: x => x.welding_position_id,
                        principalTable: "welding_positions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_welding_processes_welding_process_id",
                        column: x => x.welding_process_id,
                        principalTable: "welding_processes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_weld_params_welding_techniques_welding_technique_id",
                        column: x => x.welding_technique_id,
                        principalTable: "welding_techniques",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "welding_modes",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    current_min = table.Column<double>(nullable: true),
                    current_max = table.Column<double>(nullable: true),
                    equipment_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_process_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_modes", x => x.id);
                    table.ForeignKey(
                        name: "fk_welding_modes_welding_machines_equipment_id",
                        column: x => x.equipment_id,
                        principalTable: "welding_machines",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_welding_modes_welding_processes_welding_process_id",
                        column: x => x.welding_process_id,
                        principalTable: "welding_processes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_additional_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(nullable: false),
                    additional_material_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_additional_materials", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_additional_materials_additional_materi~",
                        column: x => x.additional_material_id,
                        principalTable: "additional_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_additional_materials_employee_certific~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_connection_forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'7', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    connection_form_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_connection_forms", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_connection_forms_connection_forms_conn~",
                        column: x => x.connection_form_id,
                        principalTable: "connection_forms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_connection_forms_employee_certificates~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_filler_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'11', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    filler_material_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_filler_materials", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_filler_materials_employee_certificates~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_filler_materials_filler_materials_fille~",
                        column: x => x.filler_material_id,
                        principalTable: "filler_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_main_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'10', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    main_material_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_main_materials", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_main_materials_employee_certificates_e~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_main_materials_main_materials_main_mate~",
                        column: x => x.main_material_id,
                        principalTable: "main_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_shielding_gases",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    shielding_gas_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_shielding_gases", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_shielding_gases_employee_certificates_~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_shielding_gases_shielding_gases_shieldi~",
                        column: x => x.shielding_gas_id,
                        principalTable: "shielding_gases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_weld_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'7', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    weld_type_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_weld_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_weld_types_employee_certificates_emplo~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_weld_types_weld_types_weld_type_id",
                        column: x => x.weld_type_id,
                        principalTable: "weld_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_welding_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_material_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_welding_materials", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_materials_employee_certificate~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_materials_welding_materials_wel~",
                        column: x => x.welding_material_id,
                        principalTable: "welding_materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_welding_positions",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'22', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_position_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_welding_positions", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_positions_employee_certificate~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_positions_welding_positions_wel~",
                        column: x => x.welding_position_id,
                        principalTable: "welding_positions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_welding_processes",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'4', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_process_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_welding_processes", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_processes_employee_certificate~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_processes_welding_processes_wel~",
                        column: x => x.welding_process_id,
                        principalTable: "welding_processes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_certificate_welding_techniques",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'19', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_certificate_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_technique_id = table.Column<int>(type: "Integer", nullable: false),
                    weld_type_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_employee_certificate_welding_techniques", x => x.id);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_techniques_employee_certificat~",
                        column: x => x.employee_certificate_id,
                        principalTable: "employee_certificates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_techniques_weld_types_weld_type~",
                        column: x => x.weld_type_id,
                        principalTable: "weld_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_employee_certificate_welding_techniques_welding_techniques_w~",
                        column: x => x.welding_technique_id,
                        principalTable: "welding_techniques",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "welding_tasks",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "Varchar", nullable: true),
                    status = table.Column<int>(type: "Integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "Date", nullable: false),
                    completion_date = table.Column<DateTime>(type: "Date", nullable: true),
                    weld_id = table.Column<int>(type: "Integer", nullable: false),
                    equipment_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_instruction_id = table.Column<int>(type: "Integer", nullable: false),
                    master_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_tasks", x => x.id);
                    table.ForeignKey(
                        name: "fk_welding_tasks_welding_machines_equipment_id",
                        column: x => x.equipment_id,
                        principalTable: "welding_machines",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_welding_tasks_employees_master_id",
                        column: x => x.master_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_welding_tasks_welds_weld_id",
                        column: x => x.weld_id,
                        principalTable: "welds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_welding_tasks_welding_instructions_welding_instruction_id",
                        column: x => x.welding_instruction_id,
                        principalTable: "welding_instructions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "welding_task_welders",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    welder_id = table.Column<int>(type: "Integer", nullable: false),
                    welding_task_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_welding_task_welders", x => x.id);
                    table.ForeignKey(
                        name: "fk_welding_task_welders_employees_welder_id",
                        column: x => x.welder_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_welding_task_welders_welding_tasks_welding_task_id",
                        column: x => x.welding_task_id,
                        principalTable: "welding_tasks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "runs",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employee_welding_task_id = table.Column<int>(type: "Integer", nullable: false),
                    date = table.Column<DateTime>(type: "Date", nullable: false),
                    work_start = table.Column<DateTime>(type: "Date", nullable: false),
                    work_time = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_runs", x => x.id);
                    table.ForeignKey(
                        name: "fk_runs_welding_task_welders_employee_welding_task_id",
                        column: x => x.employee_welding_task_id,
                        principalTable: "welding_task_welders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "measurements",
                columns: table => new
                {
                    id = table.Column<int>(type: "Integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    current = table.Column<double>(nullable: false),
                    voltage = table.Column<double>(nullable: false),
                    run_id = table.Column<int>(type: "Integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_measurements", x => x.id);
                    table.ForeignKey(
                        name: "fk_measurements_runs_run_id",
                        column: x => x.run_id,
                        principalTable: "runs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "connection_forms",
                columns: new[] { "id", "abbreviation", "description" },
                values: new object[,]
                {
                    { 1, "P", "Пластина" },
                    { 2, "T", "Труба" },
                    { 3, "Rb", "Стержень" }
                });

            migrationBuilder.InsertData(
                table: "filler_materials",
                columns: new[] { "id", "abbreviation", "description" },
                values: new object[,]
                {
                    { 1, "S", null },
                    { 2, "M", null },
                    { 3, "A", null },
                    { 4, "RA", null },
                    { 5, "RB", null },
                    { 6, "RC", null },
                    { 7, "RR", null },
                    { 8, "R", null }
                });

            migrationBuilder.InsertData(
                table: "main_materials",
                columns: new[] { "id", "description", "group", "sub_group" },
                values: new object[,]
                {
                    { 1, "Стали с установленным минимальным пределом текучести (до 275)", 1, 1 },
                    { 2, "Стали с установленным минимальным пределом текучести (от 275 до 360)", 1, 4 },
                    { 3, "Стали с улучшенной коррозионной стойкостью по отношению к кислороду", 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "organizations",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "ООО \"Протос\"" },
                    { 2, "Филиал ММУ-1 ОАО \"Могилевтехмонтаж\"" }
                });

            migrationBuilder.InsertData(
                table: "recorders",
                columns: new[] { "id", "identifier" },
                values: new object[] { 1, "00001" });

            migrationBuilder.InsertData(
                table: "weld_types",
                columns: new[] { "id", "abbreviation", "description" },
                values: new object[,]
                {
                    { 2, "FW", "Угловой шов" },
                    { 1, "BW", "Стыковой шов" }
                });

            migrationBuilder.InsertData(
                table: "welding_processes",
                columns: new[] { "id", "abbreviation", "code", "description" },
                values: new object[,]
                {
                    { 11, null, "311", "Ацетиленокислородная сварка" },
                    { 10, null, "24", "Стыковая сварка оплавлением" },
                    { 9, null, "15", "Плазменная сварка" },
                    { 7, null, "137", "Дуговая сварка в инертном газе порошковой проволокой" },
                    { 6, null, "136", "Дуговая сварка в активном газе порошковой проволокой" },
                    { 8, "TIG", "141", "Дуговая сварка в инертном газе польфрамовым электродом" },
                    { 4, "MIG", "131", "Дуговая сварка в инертном газее плавящимся электродом" },
                    { 3, "SAW", "121", "Дуговая сварка под флюсом проволочным электродом" },
                    { 2, null, "114", "Дуговая сварка порошковой проволокой" },
                    { 1, "SMAW", "111", "Дуговая сварка плавящимся покрытым электродом" },
                    { 5, "MAG", "135", "Дуговая сварка в инертном газее плавящимся электродом" }
                });

            migrationBuilder.InsertData(
                table: "welding_techniques",
                columns: new[] { "id", "abbreviation", "description" },
                values: new object[,]
                {
                    { 6, "ss", "Односторонняя сварка" },
                    { 1, "bs", "Двухсторонняя сварка" },
                    { 2, "lw,rw", "Сварка левым способом, сварка правым способом" },
                    { 3, "mb", "Сварка с защитой сварочной ванны" },
                    { 4, "ml", "Многослойная сварка" },
                    { 5, "nb", "Сварка без защиты сварочной ванны" },
                    { 7, "sl", "Однослойная сварка" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "birth_date", "employment_date", "first_name", "identification", "last_name", "middle_name", "organization_id", "position", "stamp", "user_name" },
                values: new object[,]
                {
                    { 4, new DateTime(1990, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Семен", "КВ 1845912", "Зайченко", "Сергеевич", 2, 2, "22", "szaichenko" },
                    { 3, new DateTime(1988, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Алексей", "КВ 1993091", "Пусовский", "Иванович", 2, 1, "П8", "apusovsky" },
                    { 2, new DateTime(1986, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Александр", "КВ 1789243", "Лозиков", "Евгеньевич", 2, 1, "Л4", "alozikov" },
                    { 1, new DateTime(1992, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Денис", "КВ 2291021", "Гончаров", "Геннадьевич", 2, 1, "22", "dgoncharov" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "code", "creation_date", "description", "organization_id" },
                values: new object[,]
                {
                    { 2, "T51", "2020-04-01 00:00:00", "Изогнутая труба", 2 },
                    { 1, "T24", "2020-04-01 00:00:00", "Поперечная труба", 2 }
                });

            migrationBuilder.InsertData(
                table: "welding_instructions",
                columns: new[] { "id", "creation_date", "organization_id" },
                values: new object[] { 1, new DateTime(2019, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "welding_machines",
                columns: new[] { "id", "identification", "organization_id", "recorder_id" },
                values: new object[] { 1, "KZ103492 (984)", 2, 1 });

            migrationBuilder.InsertData(
                table: "welding_positions",
                columns: new[] { "id", "abbreviation", "code", "connection_form_id", "description" },
                values: new object[,]
                {
                    { 12, "PD", "У4-2", 1, "Потолочное \"в угол\"" },
                    { 11, "PB", "У1-2-1", 1, "Нижнее \"в угол\"" },
                    { 10, "H-L045", null, 1, "наклонное под углом от 10 до 45 - труба неповоротная (сварка снизу вверх)" },
                    { 8, "PF", "С5-1, У5-1", 1, "Вертикольное снизу вверх стыковое, тавровое - труба неповоротнпя" },
                    { 7, "PA", "С1, У2-1", 1, "Нижнее стыковой и в \"угол\" (труба поворотная)" },
                    { 6, "PD", "У4-2", 1, "Потолочное тавровое" },
                    { 5, "PB", "У1-2", 1, "Нижнее тавровое" },
                    { 4, "PE", "С4", 1, "Потолочное стыковое" },
                    { 3, "PF", "С2-1, У2-1", 1, "Вертикольное снизу вверх стыковое, тавровое" },
                    { 2, "PC", "С3", 1, "Горизонтальное стыковое" },
                    { 9, "PC", "С3", 1, "Горизонтальное стыковое" },
                    { 1, "PA", "С1, У1-1", 1, "Нижнее стыковой и в \"лодочку\"" }
                });

            migrationBuilder.InsertData(
                table: "employee_certificates",
                columns: new[] { "id", "decision", "employee_id", "expires_date", "issue_date", "pipe_outer_diameter_max", "pipe_outer_diameter_min", "thickness_max", "thickness_min" },
                values: new object[,]
                {
                    { 2, "Допушен к 111 на объектах технологического оборудованияи технологических трубопроводов, паровых котлов без права работы на белорусской АЭС", 1, new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28.5, 9.0, 3.0 },
                    { 1, "Допушен к 141 на объектах технологического оборудованияи технологических трубопроводов, паровых котлов без права работы на белорусской АЭС", 2, new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28.5, 7.0, 3.0 },
                    { 3, "Допушен к 141 на объектах технологического оборудованияи технологических трубопроводов, паровых котлов без права работы на белорусской АЭС", 3, new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28.5, 7.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "weld_params",
                columns: new[] { "id", "additional_material_id", "connection_form_id", "filler_material_id", "main_material_id", "shielding_gas_id", "weld_type_id", "welding_instruction_id", "welding_material_id", "welding_position_id", "welding_process_id", "welding_technique_id", "current_max", "current_min", "pipe_outer_diameter_max", "pipe_outer_diameter_min", "thickness_max", "thickness_min" },
                values: new object[] { 1, null, 2, null, 1, null, 1, 1, null, 1, 1, null, 500.0, 0.0, 40.0, 40.0, 6.0, 6.0 });

            migrationBuilder.InsertData(
                table: "welding_modes",
                columns: new[] { "id", "equipment_id", "welding_process_id", "current_max", "current_min" },
                values: new object[] { 1, 1, 1, 500.0, 0.0 });

            migrationBuilder.InsertData(
                table: "welds",
                columns: new[] { "id", "product_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "employee_certificate_connection_forms",
                columns: new[] { "id", "connection_form_id", "employee_certificate_id" },
                values: new object[,]
                {
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 6, 2, 3 },
                    { 5, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "employee_certificate_filler_materials",
                columns: new[] { "id", "employee_certificate_id", "filler_material_id" },
                values: new object[,]
                {
                    { 9, 3, 1 },
                    { 10, 3, 2 },
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 2, 4 },
                    { 8, 2, 8 },
                    { 7, 2, 7 },
                    { 5, 2, 5 },
                    { 6, 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "employee_certificate_main_materials",
                columns: new[] { "id", "employee_certificate_id", "main_material_id" },
                values: new object[,]
                {
                    { 6, 2, 3 },
                    { 4, 2, 1 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 1, 1, 1 },
                    { 5, 2, 2 },
                    { 9, 3, 3 },
                    { 8, 3, 2 },
                    { 7, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "employee_certificate_weld_types",
                columns: new[] { "id", "employee_certificate_id", "weld_type_id" },
                values: new object[,]
                {
                    { 6, 3, 2 },
                    { 1, 1, 1 },
                    { 4, 2, 2 },
                    { 3, 2, 1 },
                    { 5, 3, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "employee_certificate_welding_positions",
                columns: new[] { "id", "employee_certificate_id", "welding_position_id" },
                values: new object[,]
                {
                    { 15, 3, 1 },
                    { 16, 3, 5 },
                    { 17, 3, 2 },
                    { 18, 3, 6 },
                    { 19, 3, 4 },
                    { 20, 3, 8 },
                    { 21, 3, 10 },
                    { 7, 1, 10 },
                    { 6, 1, 8 },
                    { 1, 1, 1 },
                    { 4, 1, 6 },
                    { 5, 1, 4 },
                    { 13, 2, 8 },
                    { 12, 2, 4 },
                    { 11, 2, 6 },
                    { 10, 2, 2 },
                    { 9, 2, 5 },
                    { 8, 2, 1 },
                    { 2, 1, 5 },
                    { 3, 1, 2 },
                    { 14, 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "employee_certificate_welding_processes",
                columns: new[] { "id", "employee_certificate_id", "welding_process_id" },
                values: new object[,]
                {
                    { 2, 2, 1 },
                    { 1, 1, 8 },
                    { 3, 3, 8 }
                });

            migrationBuilder.InsertData(
                table: "employee_certificate_welding_techniques",
                columns: new[] { "id", "employee_certificate_id", "weld_type_id", "welding_technique_id" },
                values: new object[,]
                {
                    { 13, 3, 1, 6 },
                    { 14, 3, 1, 3 },
                    { 15, 3, 1, 5 },
                    { 16, 3, 1, 1 },
                    { 17, 3, 2, 7 },
                    { 7, 2, 1, 6 },
                    { 9, 2, 1, 5 },
                    { 10, 2, 1, 1 },
                    { 11, 2, 2, 7 },
                    { 12, 2, 2, 4 },
                    { 18, 3, 2, 4 },
                    { 6, 1, 2, 4 },
                    { 5, 1, 2, 7 },
                    { 4, 1, 1, 1 },
                    { 3, 1, 1, 5 },
                    { 2, 1, 1, 3 },
                    { 1, 1, 1, 6 },
                    { 8, 2, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "welding_tasks",
                columns: new[] { "id", "completion_date", "creation_date", "description", "equipment_id", "master_id", "status", "weld_id", "welding_instruction_id" },
                values: new object[] { 1, null, new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Выполнить сварку поперечной трубы", 1, 4, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "welding_task_welders",
                columns: new[] { "id", "welder_id", "welding_task_id" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_additional_materials_additional_materi~",
                table: "employee_certificate_additional_materials",
                column: "additional_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_additional_materials_employee_certific~",
                table: "employee_certificate_additional_materials",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_connection_forms_connection_form_id",
                table: "employee_certificate_connection_forms",
                column: "connection_form_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_connection_forms_employee_certificate_~",
                table: "employee_certificate_connection_forms",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_filler_materials_employee_certificate_~",
                table: "employee_certificate_filler_materials",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_filler_materials_filler_material_id",
                table: "employee_certificate_filler_materials",
                column: "filler_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_main_materials_employee_certificate_id",
                table: "employee_certificate_main_materials",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_main_materials_main_material_id",
                table: "employee_certificate_main_materials",
                column: "main_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_shielding_gases_employee_certificate_id",
                table: "employee_certificate_shielding_gases",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_shielding_gases_shielding_gas_id",
                table: "employee_certificate_shielding_gases",
                column: "shielding_gas_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_weld_types_employee_certificate_id",
                table: "employee_certificate_weld_types",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_weld_types_weld_type_id",
                table: "employee_certificate_weld_types",
                column: "weld_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_materials_employee_certificate~",
                table: "employee_certificate_welding_materials",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_materials_welding_material_id",
                table: "employee_certificate_welding_materials",
                column: "welding_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_positions_employee_certificate~",
                table: "employee_certificate_welding_positions",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_positions_welding_position_id",
                table: "employee_certificate_welding_positions",
                column: "welding_position_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_processes_employee_certificate~",
                table: "employee_certificate_welding_processes",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_processes_welding_process_id",
                table: "employee_certificate_welding_processes",
                column: "welding_process_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_techniques_employee_certificat~",
                table: "employee_certificate_welding_techniques",
                column: "employee_certificate_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_techniques_weld_type_id",
                table: "employee_certificate_welding_techniques",
                column: "weld_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificate_welding_techniques_welding_technique_id",
                table: "employee_certificate_welding_techniques",
                column: "welding_technique_id");

            migrationBuilder.CreateIndex(
                name: "ix_employee_certificates_employee_id",
                table: "employee_certificates",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "ix_employees_organization_id",
                table: "employees",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_employees_user_name",
                table: "employees",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_measurements_run_id",
                table: "measurements",
                column: "run_id");

            migrationBuilder.CreateIndex(
                name: "ix_products_organization_id",
                table: "products",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_runs_employee_welding_task_id",
                table: "runs",
                column: "employee_welding_task_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_additional_material_id",
                table: "weld_params",
                column: "additional_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_connection_form_id",
                table: "weld_params",
                column: "connection_form_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_filler_material_id",
                table: "weld_params",
                column: "filler_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_main_material_id",
                table: "weld_params",
                column: "main_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_shielding_gas_id",
                table: "weld_params",
                column: "shielding_gas_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_weld_type_id",
                table: "weld_params",
                column: "weld_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_welding_instruction_id",
                table: "weld_params",
                column: "welding_instruction_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_welding_material_id",
                table: "weld_params",
                column: "welding_material_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_welding_position_id",
                table: "weld_params",
                column: "welding_position_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_welding_process_id",
                table: "weld_params",
                column: "welding_process_id");

            migrationBuilder.CreateIndex(
                name: "ix_weld_params_welding_technique_id",
                table: "weld_params",
                column: "welding_technique_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_instructions_organization_id",
                table: "welding_instructions",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_machines_organization_id",
                table: "welding_machines",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_machines_recorder_id",
                table: "welding_machines",
                column: "recorder_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_modes_equipment_id",
                table: "welding_modes",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_modes_welding_process_id",
                table: "welding_modes",
                column: "welding_process_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_positions_connection_form_id",
                table: "welding_positions",
                column: "connection_form_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_task_welders_welder_id",
                table: "welding_task_welders",
                column: "welder_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_task_welders_welding_task_id",
                table: "welding_task_welders",
                column: "welding_task_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_tasks_equipment_id",
                table: "welding_tasks",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_tasks_master_id",
                table: "welding_tasks",
                column: "master_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_tasks_weld_id",
                table: "welding_tasks",
                column: "weld_id");

            migrationBuilder.CreateIndex(
                name: "ix_welding_tasks_welding_instruction_id",
                table: "welding_tasks",
                column: "welding_instruction_id");

            migrationBuilder.CreateIndex(
                name: "ix_welds_product_id",
                table: "welds",
                column: "product_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_certificate_additional_materials");

            migrationBuilder.DropTable(
                name: "employee_certificate_connection_forms");

            migrationBuilder.DropTable(
                name: "employee_certificate_filler_materials");

            migrationBuilder.DropTable(
                name: "employee_certificate_main_materials");

            migrationBuilder.DropTable(
                name: "employee_certificate_shielding_gases");

            migrationBuilder.DropTable(
                name: "employee_certificate_weld_types");

            migrationBuilder.DropTable(
                name: "employee_certificate_welding_materials");

            migrationBuilder.DropTable(
                name: "employee_certificate_welding_positions");

            migrationBuilder.DropTable(
                name: "employee_certificate_welding_processes");

            migrationBuilder.DropTable(
                name: "employee_certificate_welding_techniques");

            migrationBuilder.DropTable(
                name: "measurements");

            migrationBuilder.DropTable(
                name: "weld_params");

            migrationBuilder.DropTable(
                name: "welding_modes");

            migrationBuilder.DropTable(
                name: "employee_certificates");

            migrationBuilder.DropTable(
                name: "runs");

            migrationBuilder.DropTable(
                name: "additional_materials");

            migrationBuilder.DropTable(
                name: "filler_materials");

            migrationBuilder.DropTable(
                name: "main_materials");

            migrationBuilder.DropTable(
                name: "shielding_gases");

            migrationBuilder.DropTable(
                name: "weld_types");

            migrationBuilder.DropTable(
                name: "welding_materials");

            migrationBuilder.DropTable(
                name: "welding_positions");

            migrationBuilder.DropTable(
                name: "welding_techniques");

            migrationBuilder.DropTable(
                name: "welding_processes");

            migrationBuilder.DropTable(
                name: "welding_task_welders");

            migrationBuilder.DropTable(
                name: "connection_forms");

            migrationBuilder.DropTable(
                name: "welding_tasks");

            migrationBuilder.DropTable(
                name: "welding_machines");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "welds");

            migrationBuilder.DropTable(
                name: "welding_instructions");

            migrationBuilder.DropTable(
                name: "recorders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "organizations");
        }
    }
}

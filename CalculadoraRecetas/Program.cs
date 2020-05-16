using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.IO;
//using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraRecetas
{
    static class Program
    {
        private static Autofac.IContainer Container { get; set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {


                if (args.Length > 0)
                {
                    var flag = args[0];

                    if (flag.ToLower() == "generarbackup")
                    {
                        Clases.StaticHelper.GenerateBackupHelper.GenerarBackup();
                        return;
                    }
                }

                var builder = new ContainerBuilder();

                builder.RegisterType<Clases.Helpers.MessageManager>().As<Clases.Helpers.IMessageManager>();
                builder.RegisterType<Clases.DAL.MateriasPrimasDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.MateriaPrima>>();
                builder.RegisterType<Clases.DAL.RecetasDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.Receta>>();
                builder.RegisterType<Clases.DAL.IngredientesDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.Ingrediente>>();
                builder.RegisterType<Clases.DAL.ClientesDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.Cliente>>();
                builder.RegisterType<Clases.DAL.PedidosDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.Pedido>>();

                builder.RegisterType<Clases.DAL.ProveedoresDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.Proveedor>>();
                builder.RegisterType<Clases.DAL.ServiviosDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.Servicio>>();
                builder.RegisterType<Clases.DAL.CostoMaterialesDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.CostoMateriales>>();
                builder.RegisterType<Clases.DAL.CostoServiciosDAL>().As<Clases.DAL.IObjectDAL<Clases.Dominio.CostoServicio>>();

                builder.RegisterType<Forms.frmMateriasPrimasABM>();
                builder.RegisterType<Forms.frmMateriasPrimasAddMod>();

                builder.RegisterType<Forms.frmRecetasABM>();
                builder.RegisterType<Forms.frmRecetasAddMod>();
                builder.RegisterType<Forms.frmIngredienteAdd>();

                builder.RegisterType<Forms.frmClienteAddMod>();
                builder.RegisterType<Forms.frmClientesABM>();

                builder.RegisterType<Forms.frmPedidosABM>();
                builder.RegisterType<Forms.frmPedidosAddMod>();
                builder.RegisterType<Forms.frmRecetasAddMod>();
                builder.RegisterType<Forms.frmOrdenAdd>();

                builder.RegisterType<Forms.frmEstadisticas>();

                builder.RegisterType<Forms.frmProveedoresMateriales>();
                builder.RegisterType<Forms.frmCostoMaterialesABM>();
                builder.RegisterType<Forms.frmCostoMaterialesAddMod>();

                builder.RegisterType<Forms.frmServicios>();
                builder.RegisterType<Forms.frmCostoServiciosABM>();
                builder.RegisterType<Forms.frmCostoServicioAddMod>();

                builder.RegisterType<frmMain>();

                Container = builder.Build();


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var frm = Container.Resolve<frmMain>();
                Application.Run(frm);

                //var frm = Container.Resolve<Forms.frmMateriasPrimasABM>();
                //var frm = Container.Resolve<Forms.frmRecetasABM>();
                //Application.Run(frm);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

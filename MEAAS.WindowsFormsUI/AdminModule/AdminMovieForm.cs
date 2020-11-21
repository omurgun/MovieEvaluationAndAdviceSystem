using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;

namespace MEAAS.WindowsFormsUI.AdminModule
{
    public partial class AdminMovieForm : Form
    {
        public AdminMovieForm()
        {
            InitializeComponent();
        }

        private readonly IMovieService _movieService = InstanceFactory.GetInstance<IMovieService>();
        private readonly IMovieCategoryService _movieCategoryService = InstanceFactory.GetInstance<IMovieCategoryService>();
       
        private void AdminMovieForm_Load(object sender, EventArgs e)
        {
            LoadMovieCategories();
            LoadMovies();
        }

        private void LoadMovieCategories()
        {

            var movieCategories =_movieCategoryService.GetAllMovieCategories();
            dgwMovieCategory.DataSource = movieCategories;

            cbxMovieCategory.DataSource = movieCategories;
            cbxMovieCategory.DisplayMember = "MovieCategoryName";
            cbxMovieCategory.ValueMember = "MovieCategoryId";

            cbxUpdateMovieCategory.DataSource = movieCategories;
            cbxUpdateMovieCategory.DisplayMember = "MovieCategoryName";
            cbxUpdateMovieCategory.ValueMember = "MovieCategoryId";
            
        }
        private void LoadMovies()
        {
            dgwMovies.DataSource = _movieService.GetAllMovies();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {

        }

        private void TbxRemoveMovie_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddMovieCategory_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateMovieCategory_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveMovieCategory_Click(object sender, EventArgs e)
        {

        }

        
    }
}

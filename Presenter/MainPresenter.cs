using pracownicy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownicy.Presenter
{
    class MainPresenter
    {
        private View.Form1 _view;
        private Model.Employee _model;

        public MainPresenter(View.Form1 view, Employee model)
        {
            this._view = view;
            this._model = model;
        }
    }

    }

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{
    [Activity(Label = "ViewAutoCompletTextViewXML")]
    public class ViewAutoCompletTextViewXML : Activity
    {   // pegar do xml estado
        ArrayAdapter<String> estado;
        AutoCompleteTextView lista;
        string[] xml;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ViewAutoCompletTextViewXML);
            // referencia do autocomplete
            lista = FindViewById<AutoCompleteTextView>(Resource.Id.aut_xml);

           // pegar os estados  que se encontra na pasta value/xml
           xml = Resources.GetStringArray(Resource.Array.estadoXML);

            // transformar o array e adapatar o elemento a ser 
            //visualisado
            estado = new ArrayAdapter<String>(this,
                Android.Resource.Layout.SimpleListItem1, xml);
            // colocar no autoview
            lista.Adapter = estado;

            lista.ItemClick += Lista_ItemClick;

        }

        private void Lista_ItemClick(object sender, 
            AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this,lista.Text,ToastLength.Short).Show();
        }
    }
}
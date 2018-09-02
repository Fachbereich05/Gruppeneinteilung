﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gruppenverteilung.Code;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gruppenverteilung.Models
{
    public class AdministrationModel
    {
        public List<Group> groups;
        public List<Tutor> tutors;
        public Group selectedGroup;
        public Tutor selectedTutor;
        public IEnumerable<SelectListItem> GroupSelectList { get; set; }
        public String SelectedGroupName { get; set; }
        public IEnumerable<SelectListItem> TutorSelectList { get; set; }
        public String SelectedTutorName { get; set; }
        public String AddTutorMessage { get; set; }
        public bool AddTutorIsSuccessfull { get; set; }

        public AdministrationModel()
        {
            RefreshGroups();
            RefreshTutors();
        }

        public void RefreshGroups()
        {
            groups = GlobalVariables.sorter.Groups;

            List<SelectListItem> lst = new List<SelectListItem>();

            foreach(Group group in groups)
            {
                //GroupSelectList.ToList().Add(new SelectListItem(g.Name, g.Name));
                lst.Add(new SelectListItem(group.Name, group.Name));
            }

            GroupSelectList = lst;
        }


        public void RefreshTutors()
        {
            tutors = GlobalVariables.sorter.Tutors;

            List<SelectListItem> lst = new List<SelectListItem>();

            foreach (Tutor tutor in tutors)
            {
                //GroupSelectList.ToList().Add(new SelectListItem(g.Name, g.Name));
                lst.Add(new SelectListItem(tutor.Name, tutor.Name));
            }

            TutorSelectList = lst;
        }
        public Group FindGroupByName(string selectedGroupName)
        {
            return groups.Find(i => i.Name == selectedGroupName);
        }
        public Tutor FindTutorByName(string selectedTutorName)
        {
            return tutors.Find(i => i.Name == selectedTutorName);
        }
    }
}

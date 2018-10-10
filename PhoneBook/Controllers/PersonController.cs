﻿using PhoneBook.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PhoneBookDbEntities Db = new PhoneBookDbEntities();
            List<PersonDetails> list = new List<PersonDetails>();
            var Dblist = Db.person.ToList();
            foreach (var m in Dblist)
            {
                PersonDetails n = new PersonDetails();
                n.personId = m.PersonId;
                n.FirstName = m.FirstName;
                n.MiddleName = m.MiddleName;
                n.LastName = m.LastName;
                n.dateOfBirth = Convert.ToDateTime(m.DateOfBirth);
                n.AddedOn = Convert.ToDateTime(m.AddedOn);
                n.AddedBy = m.AddedBy;
                n.FacebookId = m.FaceBookAccountId;
                n.Homeaddress = m.HomeAddress;
                n.HomeCity = m.HomeCity;
                n.TweeterId = m.TwitterId;
                n.LinkedInId = m.LinkedInId;
                n.ImagePath = m.ImagePath;
                n.EmailId = m.EmailId;
                list.Add(n);


            }

            return View(list);
           
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            List<PersonDetails> l = new List<PersonDetails>();
            PhoneBookDbEntities db = new PhoneBookDbEntities();
            var v = db.person.ToList();
            foreach (var i in v)
            {
                if (i.PersonId == id)
                {
                    PersonDetails p = new PersonDetails();
                    p.personId = i.PersonId;
                    p.FirstName = i.FirstName;
                    p.MiddleName = i.MiddleName;
                    p.LastName = i.LastName;
                    p.dateOfBirth = Convert.ToDateTime(i.DateOfBirth);
                    p.AddedOn = i.AddedOn;
                    p.Homeaddress = i.HomeAddress;
                    p.HomeCity = i.HomeCity;
                    p.FacebookId = i.FaceBookAccountId;
                    p.LinkedInId = i.LinkedInId;
                    p.UpdateOn = Convert.ToDateTime(i.UpdateOn);
                    p.ImagePath = i.ImagePath;
                    p.TweeterId = i.TwitterId;
                    p.EmailId = i.EmailId;
                    l.Add(p);
                }

            }
            return View(l);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonDetails collections)
        {
            try
            {
                // TODO: Add insert logic here
                PhoneBookDbEntities Db = new PhoneBookDbEntities();
                Person h = new Person();
                h.FirstName = collections.FirstName;
                h.MiddleName = collections.MiddleName;
                h.LastName = collections.LastName;
                h.DateOfBirth = collections.dateOfBirth;
                h.AddedOn = collections.AddedOn;
               // h.AddedBy = User.Identity.GetUserId();
                h.HomeCity = collections.HomeCity;
                h.EmailId = collections.EmailId;
                h.TwitterId = collections.TweeterId;
                h.HomeAddress = collections.Homeaddress;
                h.FaceBookAccountId = collections.FacebookId;
                h.ImagePath = collections.ImagePath;
                h.UpdateOn = Convert.ToDateTime(collections.UpdateOn);
                h.LinkedInId = collections.LinkedInId; ;

                Db.person.Add(h);
                Db.SaveChanges();



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
	public class Contact
	{
		private string _name;
		private string _email;
		private string _phone;
		
		public Contact(string name, string email, string phone)
		{
			_name = name;
			_email = email;
			_phone = phone;
		}
		public string GetName()
		{
			return _name;
		}
		public string GetEmail()
		{
			return _email; 
		}
		public string GetPhone()
		{
			return _phone;
		}
	}
	
	public class JobOpening
	{
		private string _title;
		private string _description;
		private int _experience_required;
		private string _location;
		private Contact _jobContact;
		
		private static List<JobOpening> _jobList = new List<JobOpening>();
		
		public JobOpening(string title, string description, int experience, string location, Contact jobContact)
		{
		  _title = title;
		  _description = description;
		  _experience_required = experience;
		  _location = location;
		  _jobContact = jobContact;
		}
		public string GetTitle()
		{
		  return _title;
		}
		public string GetDescription()
		{
		  return _description;
		}
		public int GetExperience()
		{
		  return _experience_required;
		}
		public string GetLocation()
		{
		  return _location;
		}
		public Contact GetContact()
		{
			return _jobContact;
		}
		public static List<JobOpening> GetAll()
		{
		  return _jobList;
		}
		public void Save()
		{
		  _jobList.Add(this);
		}
	}
}
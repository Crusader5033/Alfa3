using Alfa3.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Alfa3.Controller
{
    /// <summary>
    /// Represents a controller class for handling operations related to exams (zkousky).
    /// </summary>
    internal class ZkouskaController
    {
        private Zkouska z;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZkouskaController"/> class.
        /// </summary>
        public ZkouskaController()
        {
            // Instantiates a Zkouska object to interact with exam-related database operations.
            this.z = new Zkouska();
        }

        /// <summary>
        /// Retrieves a DataTable containing information about exams.
        /// </summary>
        /// <returns>A DataTable containing exam information.</returns>
        public DataTable ListZkousky()
        {
            // Calls the GetZkousky method of the associated Zkouska object to retrieve exam information.
            return this.z.GetZkousky();
        }

        /// <summary>
        /// Adds a new exam to the database.
        /// </summary>
        /// <param name="name">ID of the soldier taking the exam.</param>
        /// <param name="test">ID of the specialization for which the exam is conducted.</param>
        /// <param name="place">The location where the exam took place.</param>
        /// <param name="result">The result of the exam.</param>
        /// <param name="when">The date and time when the exam took place.</param>
        public void AddZkouska(int name, int test, string place, string result, DateTime when)
        {
            // Calls the AddZkouska method of the associated Zkouska object to add a new exam to the database.
            this.z.AddZkouska(name, test, when, place, result);
        }

       

        /// <summary>
        /// Deletes exams associated with a specific soldier by ID.
        /// </summary>
        /// <param name="id">ID of the soldier for whom exams will be deleted.</param>
        public void DeleteZkouskaByVojakId(int id)
        {
            // Calls the DeleteZkouskaVojakId method of the associated Zkouska object to delete exams associated with a specific soldier by ID.
            this.z.DeleteZkouskaVojakId(id);
        }
    }
}

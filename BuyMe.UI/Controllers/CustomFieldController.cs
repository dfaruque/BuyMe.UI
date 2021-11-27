﻿using BuyMe.Application.CustomField.Commonds.DeleteCustomField;
using BuyMe.Application.CustomField.Commonds.UpSertCustomField;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BuyMe.UI.Controllers
{
    public class CustomFieldController: BaseController
    {
        [HttpPost]
        public async Task<IActionResult> UpSertCustomField(UpSertCustomerFieldCommond commond)
        {
            return Ok(await Mediator.Send(commond));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCustomField(DeleteCustomFieldCommond commond)
        {
            return Ok(await Mediator.Send(commond));
        }
    }
}

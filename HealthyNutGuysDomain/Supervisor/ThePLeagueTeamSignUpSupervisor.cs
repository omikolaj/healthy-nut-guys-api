using System;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Converters.TeamConverters;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Models.TeamSignUp;
using HealthyNutGuysDomain.ViewModels;
using HealthyNutGuysDomain.ViewModels.Team;

namespace HealthyNutGuysDomain.Supervisor
{
  public partial class HealthyNutGuysSupervisor : IHealthyNutGuysSupervisor
  {
    #region Methods
    public async Task<TeamSignUpFormViewModel> AddTeamSignUpFormAsync(TeamSignUpFormViewModel newTeamViewModel, CancellationToken ct = default(CancellationToken))
    {
      TeamSignUpForm newTeamForm = new TeamSignUpForm()
      {
        Name = newTeamViewModel.Name
      };

      newTeamForm = await this._teamSignUpRepository.AddSignUpFormAsync(newTeamForm);
      newTeamViewModel.Id = newTeamForm.Id;

      Contact teamContact = new Contact()
      {
        FirstName = newTeamViewModel.Contact.FirstName,
        LastName = newTeamViewModel.Contact.LastName,
        Email = newTeamViewModel.Contact.Email,
        PhoneNumber = newTeamViewModel.Contact.PhoneNumber,
        TeamSignUpFormId = newTeamViewModel.Id
      };

      newTeamViewModel.Contact = ContactConverter.Convert(await this._teamSignUpRepository.AddTeamContactAsync(teamContact, ct));

      return newTeamViewModel;
    }

    public async Task<ContactViewModel> AddTeamContactAsync(ContactViewModel contactViewModel, CancellationToken ct = default(CancellationToken))
    {
      Contact contact = new Contact()
      {
        FirstName = contactViewModel.FirstName,
        LastName = contactViewModel.LastName,
        Email = contactViewModel.Email,
        PhoneNumber = contactViewModel.PhoneNumber,
        TeamSignUpFormId = contactViewModel.TeamSignUpFormId
      };

      contact = await this._teamSignUpRepository.AddTeamContactAsync(contact, ct);
      contactViewModel.Id = contact.Id;

      return contactViewModel;
    }

    #endregion
  }
}
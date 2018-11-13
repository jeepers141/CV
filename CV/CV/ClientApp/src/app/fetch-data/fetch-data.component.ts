import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public profile: Profile;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Profile>(baseUrl + 'api/ProfileData/ProfileDetails2').subscribe(result => {
      this.profile = result;
    }, error => console.error(error));
  }
}

interface Profile {
  firstName: string;
  lastName: string;
}

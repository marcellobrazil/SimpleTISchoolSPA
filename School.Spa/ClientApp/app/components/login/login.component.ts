import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { contentHeaders } from '../common/headers';

@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})
export class LoginComponent {

    constructor(public http: Http, @Inject('ORIGIN_URL') public originUrl: string, public router: Router) {
    }


    Authenticate(event, login, password) {
        event.preventDefault();

        let body = JSON.stringify({ login, password });
        this.http.post(this.originUrl + '/api/token', body, { headers: contentHeaders })
            .subscribe(
            response => {
                let responseJson = response.json();
                localStorage.setItem('token', responseJson.accessToken);
                this.router.navigate(['/courses']);
            },
            error => {
                alert(error.text());
                console.log(error.text());
            }
            );
    }
}

import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { AuthHttp, JwtHelper  } from 'angular2-jwt';

@Component({
    selector: 'courses',
    templateUrl: './courses.component.html'
})
export class CoursesComponent {
    public courses: course[];

    constructor(http: Http, authHttp: AuthHttp, jwtHelper: JwtHelper, @Inject('ORIGIN_URL') originUrl: string) {

        http.get(originUrl + '/api/course').subscribe(result => {
            this.courses = result.json() as course[];
        });
    }
}

interface course {
    name: string;
    description: string;
}

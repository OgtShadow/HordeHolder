import { ChangeDetectionStrategy, Component } from '@angular/core';
import { ThemeSelector } from '../theme-selector/theme-selector';

@Component({
  selector: 'app-header',
  imports: [ThemeSelector],
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class Header { 
  
}

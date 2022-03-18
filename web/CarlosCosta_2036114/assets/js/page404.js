  v.valHooks[this] = v.extend(v.valHooks[this], {
      set: function(e, t) {
        if (v.isArray(t))
          return e.checked = v.inArray(v(e).val(), t) >= 0
      }
    });
  var $ = /^(?:textarea|input|select)$/i,
    J = /^([^\.]*|)(?:\.(.+)|)$/,
    K = /(?:^|\s)hover(\.\S+|)\b/,
    Q = /^key/,
    G = /^(?:mouse|contextmenu)|click/,
    Y = /^(?:focusinfocus|focusoutblur)$/,
    Z = function(e) {
      return v.event.special.hover ? e : e.replace(K, "mouseenter$1 mouseleave$1")
    };
  v.event = {
      add: function(e, n, r, i, s) {
        var o, u, a, f, l, c, h, p, d, m, g;
        if (e.nodeType === 3 || e.nodeType === 8 || !n || !r || !(o = v._data(e)))
          return;
        r.handler && (d = r, r = d.handler, s = d.selector), r.guid || (r.guid = v.guid++), a = o.events, a || (o.events = a = {}), u = o.handle, u || (o.handle = u = function(e) {
          return typeof v == "undefined" || !!e && v.event.triggered === e.type ? t : v.event.dispatch.apply(u.elem, arguments)
        }, u.elem = e), n = v.trim(Z(n)).split(" ");
        for (f = 0; f < n.length; f++) {
          l = J.exec(n[f]) || [], c = l[1], h = (l[2] || "").split(".").sort(), g = v.event.special[c] || {}, c = (s ? g.delegateType : g.bindType) || c, g = v.event.special[c] || {}, p = v.extend({
            type: c,
            origType: l[1],
            data: i,
            handler: r,
            guid: r.guid,
            selector: s,
            needsContext: s && v.expr.match.needsContext.test(s),
            namespace: h.join(".")
          }, d), m = a[c];
          if (!m) {
            m = a[c] = [], m.delegateCount = 0;
            if (!g.setup || g.setup.call(e, i, h, u) === !1)
              e.addEventListener ? e.addEventListener(c, u, !1) : e.attachEvent && e.attachEvent("on" + c, u)
          }
          g.add && (g.add.call(e, p), p.handler.guid || (p.handler.guid = r.guid)), s ? m.splice(m.delegateCount++, 0, p) : m.push(p), v.event.global[c] = !0
        }
        e = null
      },
      global: {},
      remove: function(e, t, n, r, i) {
        var s, o, u, a, f, l, c, h, p, d, m, g = v.hasData(e) && v._data(e);
        if (!g || !(h = g.events))
          return;
        t = v.trim(Z(t || "")).split(" ");
        for (s = 0; s < t.length; s++) {
          o = J.exec(t[s]) || [], u = a = o[1], f = o[2];
          if (!u) {
            for (u in h)
              v.event.remove(e, u + t[s], n, r, !0);
            continue
          }
          p = v.event.special[u] || {}, u = (r ? p.delegateType : p.bindType) || u, d = h[u] || [], l = d.length, f = f ? new RegExp("(^|\\.)" + f.split(".").sort().join("\\.(?:.*\\.|)") + "(\\.|$)") : null;
          for (c = 0; c < d.length; c++)
            m = d[c], (i || a === m.origType) && (!n || n.guid === m.guid) && (!f || f.test(m.namespace)) && (!r || r === m.selector || r === "**" && m.selector) && (d.splice(c--, 1), m.selector && d.delegateCount--, p.remove && p.remove.call(e, m));
          d.length === 0 && l !== d.length && ((!p.teardown || p.teardown.call(e, f, g.handle) === !1) && v.removeEvent(e, u, g.handle), delete h[u])
        }
        v.isEmptyObject(h) && (delete g.handle, v.removeData(e, "events", !0))
      },
      customEvent: {
        getData: !0,
        setData: !0,
        changeData: !0
      },
      trigger: function(n, r, s, o) {
        if (!s || s.nodeType !== 3 && s.nodeType !== 8) {
          var u, a, f, l, c, h, p, d, m, g, y = n.type || n,
            b = [];
          if (Y.test(y + v.event.triggered))
            return;
          y.indexOf("!") >= 0 && (y = y.slice(0, -1), a = !0), y.indexOf(".") >= 0 && (b = y.split("."), y = b.shift(), b.sort());
          if ((!s || v.event.customEvent[y]) && !v.event.global[y])
            return;
          n = typeof n == "object" ? n[v.expando] ? n : new v.Event(y, n) : new v.Event(y), n.type = y, n.isTrigger = !0, n.exclusive = a, n.namespace = b.join("."), n.namespace_re = n.namespace ? new RegExp("(^|\\.)" + b.join("\\.(?:.*\\.|)") + "(\\.|$)") : null, h = y.indexOf(":") < 0 ? "on" + y : "";
          if (!s) {
            u = v.cache;
            for (f in u)
              u[f].events && u[f].events[y] && v.event.trigger(n, r, u[f].handle.elem, !0);
            return
          }
          n.result = t, n.target || (n.target = s), r = r != null ? v.makeArray(r) : [], r.unshift(n), p = v.event.special[y] || {};
          if (p.trigger && p.trigger.apply(s, r) === !1)
            return;
          m = [
            [s, p.bindType || y]
          ];
          if (!o && !p.noBubble && !v.isWindow(s)) {
            g = p.delegateType || y, l = Y.test(g + y) ? s : s.parentNode;
            for (c = s; l; l = l.parentNode)
              m.push([l, g]), c = l;
            c === (s.ownerDocument || i) && m.push([c.defaultView || c.parentWindow || e, g])
          }
          for (f = 0; f < m.length && !n.isPropagationStopped(); f++)
            l = m[f][0], n.type = m[f][1], d = (v._data(l, "events") || {})[n.type] && v._data(l, "handle"), d && d.apply(l, r), d = h && l[h], d && v.acceptData(l) && d.apply && d.apply(l, r) === !1 && n.preventDefault();
          return n.type = y, !o && !n.isDefaultPrevented() && (!p._default || p._default.apply(s.ownerDocument, r) === !1) && (y !== "click" || !v.nodeName(s, "a")) && v.acceptData(s) && h && s[y] && (y !== "focus" && y !== "blur" || n.target.offsetWidth !== 0) && !v.isWindow(s) && (c = s[h], c && (s[h] = null), v.event.triggered = y, s[y](), v.event.triggered = t, c && (s[h] = c)), n.result
        }
        return
      },
      dispatch: function(n) {
        n = v.event.fix(n || e.event);
        var r, i, s, o, u, a, f, c, h, p, d = (v._data(this, "events") || {})[n.type] || [],
          m = d.delegateCount,
          g = l.call(arguments),
          y = !n.exclusive && !n.namespace,
          b = v.event.special[n.type] || {},
          w = [];
        g[0] = n, n.delegateTarget = this;
        if (b.preDispatch && b.preDispatch.call(this, n) === !1)
          return;
        if (m && (!n.button || n.type !== "click"))
          for (s = n.target; s != this; s = s.parentNode || this)
            if (s.disabled !== !0 || n.type !== "click") {
              u = {}, f = [];
              for (r = 0; r < m; r++)
                c = d[r], h = c.selector, u[h] === t && (u[h] = c.needsContext ? v(h, this).index(s) >= 0 : v.find(h, this, null, [s]).length), u[h] && f.push(c);
              f.length && w.push({
                elem: s,
                matches: f
              })
            }
        d.length > m && w.push({
          elem: this,
          matches: d.slice(m)
        });
        for (r = 0; r < w.length && !n.isPropagationStopped(); r++) {
          a = w[r], n.currentTarget = a.elem;
          for (i = 0; i < a.matches.length && !n.isImmediatePropagationStopped(); i++) {
            c = a.matches[i];
            if (y || !n.namespace && !c.namespace || n.namespace_re && n.namespace_re.test(c.namespace))
              n.data = c.data, n.handleObj = c, o = ((v.event.special[c.origType] || {}).handle || c.handler).apply(a.elem, g), o !== t && (n.result = o, o === !1 && (n.preventDefault(), n.stopPropagation()))
          }
        }
        return b.postDispatch && b.postDispatch.call(this, n), n.result
      },
      props: "attrChange attrName relatedNode srcElement altKey bubbles cancelable ctrlKey currentTarget eventPhase metaKey relatedTarget shiftKey target timeStamp view which".split(" "),
      fixHooks: {},
      keyHooks: {
        props: "char charCode key keyCode".split(" "),
        filter: function(e, t) {
          return e.which == null && (e.which = t.charCode != null ? t.charCode : t.keyCode), e
        }
      },
      mouseHooks: {
        props: "button buttons clientX clientY fromElement offsetX offsetY pageX pageY screenX screenY toElement".split(" "),
        filter: function(e, n) {
          var r, s, o, u = n.button,
            a = n.fromElement;
          return e.pageX == null && n.clientX != null && (r = e.target.ownerDocument || i, s = r.documentElement, o = r.body, e.pageX = n.clientX + (s && s.scrollLeft || o && o.scrollLeft || 0) - (s && s.clientLeft || o && o.clientLeft || 0), e.pageY = n.clientY + (s && s.scrollTop || o && o.scrollTop || 0) - (s && s.clientTop || o && o.clientTop || 0)), !e.relatedTarget && a && (e.relatedTarget = a === e.target ? n.toElement : a), !e.which && u !== t && (e.which = u & 1 ? 1 : u & 2 ? 3 : u & 4 ? 2 : 0), e
        }
      },
      fix: function(e) {
        if (e[v.expando])
          return e;
        var t, n, r = e,
          s = v.event.fixHooks[e.type] || {},
          o = s.props ? this.props.concat(s.props) : this.props;
        e = v.Event(r);
        for (t = o.length; t;)
          n = o[--t], e[n] = r[n];
        return e.target || (e.target = r.srcElement || i), e.target.nodeType === 3 && (e.target = e.target.parentNode), e.metaKey = !!e.metaKey, s.filter ? s.filter(e, r) : e
      },
      special: {
        load: {
          noBubble: !0
        },
        focus: {
          delegateType: "focusin"
        },
        blur: {
          delegateType: "focusout"
        },
        beforeunload: {
          setup: function(e, t, n) {
            v.isWindow(this) && (this.onbeforeunload = n)
          },
          teardown: function(e, t) {
            this.onbeforeunload === t && (this.onbeforeunload = null)
          }
        }
      },
      simulate: function(e, t, n, r) {
        var i = v.extend(new v.Event, n, {
          type: e,
          isSimulated: !0,
          originalEvent: {}
        });
        r ? v.event.trigger(i, null, t) : v.event.dispatch.call(t, i), i.isDefaultPrevented() && n.preventDefault()
      }
    }, v.event.handle = v.event.dispatch, v.removeEvent = i.removeEventListener ? function(e, t, n) {
      e.removeEventListener && e.removeEventListener(t, n, !1)
    } : function(e, t, n) {
      var r = "on" + t;
      e.detachEvent && (typeof e[r] == "undefined" && (e[r] = null), e.detachEvent(r, n))
    }, v.Event = function(e, t) {
      if (!(this instanceof v.Event))
        return new v.Event(e, t);
      e && e.type ? (this.originalEvent = e, this.type = e.type, this.isDefaultPrevented = e.defaultPrevented || e.returnValue === !1 || e.getPreventDefault && e.getPreventDefault() ? tt : et) : this.type = e, t && v.extend(this, t), this.timeStamp = e && e.timeStamp || v.now(), this[v.expando] = !0
    }, v.Event.prototype = {
      preventDefault: function() {
        this.isDefaultPrevented = tt;
        var e = this.originalEvent;
        if (!e)
          return;
        e.preventDefault ? e.preventDefault() : e.returnValue = !1
      },
      stopPropagation: function() {
        this.isPropagationStopped = tt;
        var e = this.originalEvent;
        if (!e)
          return;
        e.stopPropagation && e.stopPropagation(), e.cancelBubble = !0
      },
      stopImmediatePropagation: function() {
        this.isImmediatePropagationStopped = tt, this.stopPropagation()
      },
      isDefaultPrevented: et,
      isPropagationStopped: et,
      isImmediatePropagationStopped: et
    }, v.each({
      mouseenter: "mouseover",
      mouseleave: "mouseout"
    }, function(e, t) {
      v.event.special[e] = {
        delegateType: t,
        bindType: t,
        handle: function(e) {
          var n, r = this,
            i = e.relatedTarget,
            s = e.handleObj,
            o = s.selector;
          if (!i || i !== r && !v.contains(r, i))
            e.type = s.origType, n = s.handler.apply(this, arguments), e.type = t;
          return n
        }
      }
    }), v.support.submitBubbles || (v.event.special.submit = {
      setup: function() {
        if (v.nodeName(this, "form"))
          return !1;
        v.event.add(this, "click._submit keypress._submit", function(e) {
          var n = e.target,
            r = v.nodeName(n, "input") || v.nodeName(n, "button") ? n.form : t;
          r && !v._data(r, "_submit_attached") && (v.event.add(r, "submit._submit", function(e) {
            e._submit_bubble = !0
          }), v._data(r, "_submit_attached", !0))
        })
      },
      postDispatch: function(e) {
        e._submit_bubble && (delete e._submit_bubble, this.parentNode && !e.isTrigger && v.event.simulate("submit", this.parentNode, e, !0))
      },
      teardown: function() {
        if (v.nodeName(this, "form"))
          return !1;
        v.event.remove(this, "._submit")
      }
    }), v.support.changeBubbles || (v.event.special.change = {
      setup: function() {
        if ($.test(this.nodeName)) {
          if (this.type === "checkbox" || this.type === "radio")
            v.event.add(this, "propertychange._change", function(e) {
              e.originalEvent.propertyName === "checked" && (this._just_changed = !0)
            }), v.event.add(this, "click._change", function(e) {
              this._just_changed && !e.isTrigger && (this._just_changed = !1), v.event.simulate("change", this, e, !0)
            });
          return !1
        }
        v.event.add(this, "beforeactivate._change", function(e) {
          var t = e.target;
          $.test(t.nodeName) && !v._data(t, "_change_attached") && (v.event.add(t, "change._change", function(e) {
            this.parentNode && !e.isSimulated && !e.isTrigger && v.event.simulate("change", this.parentNode, e, !0)
          }), v._data(t, "_change_attached", !0))
        })
      },
      handle: function(e) {
        var t = e.target;
        if (this !== t || e.isSimulated || e.isTrigger || t.type !== "radio" && t.type !== "checkbox")
          return e.handleObj.handler.apply(this, arguments)
      },
      teardown: function() {
        return v.event.remove(this, "._change"), !$.test(this.nodeName)
      }
    }), v.support.focusinBubbles || v.each({
      focus: "focusin",
      blur: "focusout"
    }, function(e, t) {
      var n = 0,
        r = function(e) {
          v.event.simulate(t, e.target, v.event.fix(e), !0)
        };
      v.event.special[t] = {
        setup: function() {
          n++ === 0 && i.addEventListener(e, r, !0)
        },
        teardown: function() {
          --n === 0 && i.removeEventListener(e, r, !0)
        }
      }
    }), v.fn.extend({
      on: function(e, n, r, i, s) {
        var o, u;
        if (typeof e == "object") {
          typeof n != "string" && (r = r || n, n = t);
          for (u in e)
            this.on(u, n, r, e[u], s);
          return this
        }
        r == null && i == null ? (i = n, r = n = t) : i == null && (typeof n == "string" ? (i = r, r = t) : (i = r, r = n, n = t));
        if (i === !1)
          i = et;
        else if (!i)
          return this;
        return s === 1 && (o = i, i = function(e) {
          return v().off(e), o.apply(this, arguments)
        }, i.guid = o.guid || (o.guid = v.guid++)), this.each(function() {
          v.event.add(this, e, i, r, n)
        })
      },
      one: function(e, t, n, r) {
        return this.on(e, t, n, r, 1)
      },
      off: function(e, n, r) {
        var i, s;
        if (e && e.preventDefault && e.handleObj)
          return i = e.handleObj, v(e.delegateTarget).off(i.namespace ? i.origType + "." + i.namespace : i.origType, i.selector, i.handler), this;
        if (typeof e == "object") {
          for (s in e)
            this.off(s, n, e[s]);
          return this
        }
        if (n === !1 || typeof n == "function")
          r = n, n = t;
        return r === !1 && (r = et), this.each(function() {
          v.event.remove(this, e, r, n)
        })
      },
      bind: function(e, t, n) {
        return this.on(e, null, t, n)
      },
      unbind: function(e, t) {
        return this.off(e, null, t)
      },
      live: function(e, t, n) {
        return v(this.context).on(e, this.selector, t, n), this
      },
      die: function(e, t) {
        return v(this.context).off(e, this.selector || "**", t), this
      },
      delegate: function(e, t, n, r) {
        return this.on(t, e, n, r)
      },
      undelegate: function(e, t, n) {
        return arguments.length === 1 ? this.off(e, "**") : this.off(t, e || "**", n)
      },
      trigger: function(e, t) {
        return this.each(function() {
          v.event.trigger(e, t, this)
        })
      },
      triggerHandler: function(e, t) {
        if (this[0])
          return v.event.trigger(e, t, this[0], !0)
      },
      toggle: function(e) {
        var t = arguments,
          n = e.guid || v.guid++,
          r = 0,
          i = function(n) {
            var i = (v._data(this, "lastToggle" + e.guid) || 0) % r;
            return v._data(this, "lastToggle" + e.guid, i + 1), n.preventDefault(), t[i].apply(this, arguments) || !1
          };
        i.guid = n;
        while (r < t.length)
          t[r++].guid = n;
        return this.click(i)
      },
      hover: function(e, t) {
        return this.mouseenter(e).mouseleave(t || e)
      }
    }), v.each("blur focus focusin focusout load resize scroll unload click dblclick mousedown mouseup mousemove mouseover mouseout mouseenter mouseleave change select submit keydown keypress keyup error contextmenu".split(" "), function(e, t) {
      v.fn[t] = function(e, n) {
        return n == null && (n = e, e = null), arguments.length > 0 ? this.on(t, null, e, n) : this.trigger(t)
      }, Q.test(t) && (v.event.fixHooks[t] = v.event.keyHooks), G.test(t) && (v.event.fixHooks[t] = v.event.mouseHooks)
    }),
    function(e, t) {
      function nt(e, t, n, r) {
        n = n || [], t = t || g;
        var i, s, a, f, l = t.nodeType;
        if (!e || typeof e != "string")
          return n;
        if (l !== 1 && l !== 9)
          return [];
        a = o(t);
        if (!a && !r)
          if (i = R.exec(e))
            if (f = i[1]) {
              if (l === 9) {
                s = t.getElementById(f);
                if (!s || !s.parentNode)
                  return n;
                if (s.id === f)
                  return n.push(s), n
              } else if (t.ownerDocument && (s = t.ownerDocument.getElementById(f)) && u(t, s) && s.id === f)
                return n.push(s), n
            } else {
              if (i[2])
                return S.apply(n, x.call(t.getElementsByTagName(e), 0)), n;
              if ((f = i[3]) && Z && t.getElementsByClassName)
                return S.apply(n, x.call(t.getElementsByClassName(f), 0)), n
            }
        return vt(e.replace(j, "$1"), t, n, r, a)
      }

      function rt(e) {
        return function(t) {
          var n = t.nodeName.toLowerCase();
          return n === "input" && t.type === e
        }
      }

      function it(e) {
        return function(t) {
          var n = t.nodeName.toLowerCase();
          return (n === "input" || n === "button") && t.type === e
        }
      }

      function st(e) {
        return N(function(t) {
          return t = +t, N(function(n, r) {
            var i, s = e([], n.length, t),
              o = s.length;
            while (o--)
              n[i = s[o]] && (n[i] = !(r[i] = n[i]))
          })
        })
      }

      function ot(e, t, n) {
        if (e === t)
          return n;
        var r = e.nextSibling;
        while (r) {
          if (r === t)
            return -1;
          r = r.nextSibling
        }
        return 1
      }

      function ut(e, t) {
        var n, r, s, o, u, a, f, l = L[d][e + " "];
        if (l)
          return t ? 0 : l.slice(0);
        u = e, a = [], f = i.preFilter;
        while (u) {
          if (!n || (r = F.exec(u)))
            r && (u = u.slice(r[0].length) || u), a.push(s = []);
          n = !1;
          if (r = I.exec(u))
            s.push(n = new m(r.shift())), u = u.slice(n.length), n.type = r[0].replace(j, " ");
          for (o in i.filter)(r = J[o].exec(u)) && (!f[o] || (r = f[o](r))) && (s.push(n = new m(r.shift())), u = u.slice(n.length), n.type = o, n.matches = r);
          if (!n)
            break
        }
        return t ? u.length : u ? nt.error(e) : L(e, a).slice(0)
      }

      function at(e, t, r) {
        var i = t.dir,
          s = r && t.dir === "parentNode",
          o = w++;
        return t.first ? function(t, n, r) {
          while (t = t[i])
            if (s || t.nodeType === 1)
              return e(t, n, r)
        } : function(t, r, u) {
          if (!u) {
            var a, f = b + " " + o + " ",
              l = f + n;
            while (t = t[i])
              if (s || t.nodeType === 1) {
                if ((a = t[d]) === l)
                  return t.sizset;
                if (typeof a == "string" && a.indexOf(f) === 0) {
                  if (t.sizset)
                    return t
                } else {
                  t[d] = l;
                  if (e(t, r, u))
                    return t.sizset = !0, t;
                  t.sizset = !1
                }
              }
          } else
            while (t = t[i])
              if (s || t.nodeType === 1)
                if (e(t, r, u))
                  return t
        }
      }

      function ft(e) {
        return e.length > 1 ? function(t, n, r) {
          var i = e.length;
          while (i--)
            if (!e[i](t, n, r))
              return !1;
          return !0
        } : e[0]
      }

      function lt(e, t, n, r, i) {
        var s, o = [],
          u = 0,
          a = e.length,
          f = t != null;
        for (; u < a; u++)
          if (s = e[u])
            if (!n || n(s, r, i))
              o.push(s), f && t.push(u);
        return o
      }

      function ct(e, t, n, r, i, s) {
        return r && !r[d] && (r = ct(r)), i && !i[d] && (i = ct(i, s)), N(function(s, o, u, a) {
          var f, l, c, h = [],
            p = [],
            d = o.length,
            v = s || dt(t || "*", u.nodeType ? [u] : u, []),
            m = e && (s || !t) ? lt(v, h, e, u, a) : v,
            g = n ? i || (s ? e : d || r) ? [] : o : m;
          n && n(m, g, u, a);
          if (r) {
            f = lt(g, p), r(f, [], u, a), l = f.length;
            while (l--)
              if (c = f[l])
                g[p[l]] = !(m[p[l]] = c)
          }
          if (s) {
            if (i || e) {
              if (i) {
                f = [], l = g.length;
                while (l--)(c = g[l]) && f.push(m[l] = c);
                i(null, g = [], f, a)
              }
              l = g.length;
              while (l--)(c = g[l]) && (f = i ? T.call(s, c) : h[l]) > -1 && (s[f] = !(o[f] = c))
            }
          } else
            g = lt(g === o ? g.splice(d, g.length) : g), i ? i(null, o, g, a) : S.apply(o, g)
        })
      }

      function ht(e) {
        var t, n, r, s = e.length,
          o = i.relative[e[0].type],
          u = o || i.relative[" "],
          a = o ? 1 : 0,
          f = at(function(e) {
            return e === t
          }, u, !0),
          l = at(function(e) {
            return T.call(t, e) > -1
          }, u, !0),
          h = [function(e, n, r) {
            return !o && (r || n !== c) || ((t = n).nodeType ? f(e, n, r) : l(e, n, r))
          }];
        for (; a < s; a++)
          if (n = i.relative[e[a].type])
            h = [at(ft(h), n)];
          else {
            n = i.filter[e[a].type].apply(null, e[a].matches);
            if (n[d]) {
              r = ++a;
              for (; r < s; r++)
                if (i.relative[e[r].type])
                  break;
              return ct(a > 1 && ft(h), a > 1 && e.slice(0, a - 1).join("").replace(j, "$1"), n, a < r && ht(e.slice(a, r)), r < s && ht(e = e.slice(r)), r < s && e.join(""))
            }
            h.push(n)
          }
        return ft(h)
      }

      function pt(e, t) {
        var r = t.length > 0,
          s = e.length > 0,
          o = function(u, a, f, l, h) {
            var p, d, v, m = [],
              y = 0,
              w = "0",
              x = u && [],
              T = h != null,
              N = c,
              C = u || s && i.find.TAG("*", h && a.parentNode || a),
              k = b += N == null ? 1 : Math.E;
            T && (c = a !== g && a, n = o.el);
            for (;
              (p = C[w]) != null; w++) {
              if (s && p) {
                for (d = 0; v = e[d]; d++)
                  if (v(p, a, f)) {
                    l.push(p);
                    break
                  }
                T && (b = k, n = ++o.el)
              }
              r && ((p = !v && p) && y--, u && x.push(p))
            }
            y += w;
            if (r && w !== y) {
              for (d = 0; v = t[d]; d++)
                v(x, m, a, f);
              if (u) {
                if (y > 0)
                  while (w--) !x[w] && !m[w] && (m[w] = E.call(l));
                m = lt(m)
              }
              S.apply(l, m), T && !u && m.length > 0 && y + t.length > 1 && nt.uniqueSort(l)
            }
            return T && (b = k, c = N), x
          };
        return o.el = 0, r ? N(o) : o
      }

      function dt(e, t, n) {
        var r = 0,
          i = t.length;
        for (; r < i; r++)
          nt(e, t[r], n);
        return n
      }

      function vt(e, t, n, r, s) {
        var o, u, f, l, c, h = ut(e),
          p = h.length;
        if (!r && h.length === 1) {
          u = h[0] = h[0].slice(0);
          if (u.length > 2 && (f = u[0]).type === "ID" && t.nodeType === 9 && !s && i.relative[u[1].type]) {
            t = i.find.ID(f.matches[0].replace($, ""), t, s)[0];
            if (!t)
              return n;
            e = e.slice(u.shift().length)
          }
          for (o = J.POS.test(e) ? -1 : u.length - 1; o >= 0; o--) {
            f = u[o];
            if (i.relative[l = f.type])
              break;
            if (c = i.find[l])
              if (r = c(f.matches[0].replace($, ""), z.test(u[0].type) && t.parentNode || t, s)) {
                u.splice(o, 1), e = r.length && u.join("");
                if (!e)
                  return S.apply(n, x.call(r, 0)), n;
                break
              }
          }
        }
        return a(e, h)(r, t, s, n, z.test(e)), n
      }

      function mt() {}
      var n, r, i, s, o, u, a, f, l, c, h = !0,
        p = "undefined",
        d = ("sizcache" + Math.random()).replace(".", ""),
        m = String,
        g = e.document,
        y = g.documentElement,
        b = 0,
        w = 0,
        E = [].pop,
        S = [].push,
        x = [].slice,
        T = [].indexOf || function(e) {
          var t = 0,
            n = this.length;
          for (; t < n; t++)
            if (this[t] === e)
              return t;
          return -1
        },
        N = function(e, t) {
          return e[d] = t == null || t, e
        },
        C = function() {
          var e = {},
            t = [];
          return N(function(n, r) {
            return t.push(n) > i.cacheLength && delete e[t.shift()], e[n + " "] = r
          }, e)
        },
        k = C(),
        L = C(),
        A = C(),
        O = "[\\x20\\t\\r\\n\\f]",
        M = "(?:\\\\.|[-\\w]|[^\\x00-\\xa0])+",
        _ = M.replace("w", "w#"),
        D = "([*^$|!~]?=)",
        P = "\\[" + O + "*(" + M + ")" + O + "*(?:" + D + O + "*(?:(['\"])((?:\\\\.|[^\\\\])*?)\\3|(" + _ + ")|)|)" + O + "*\\]",
        H = ":(" + M + ")(?:\\((?:(['\"])((?:\\\\.|[^\\\\])*?)\\2|([^()[\\]]*|(?:(?:" + P + ")|[^:]|\\\\.)*|.*))\\)|)",
        B = ":(even|odd|eq|gt|lt|nth|first|last)(?:\\(" + O + "*((?:-\\d)?\\d*)" + O + "*\\)|)(?=[^-]|$)",
        j = new RegExp("^" + O + "+|((?:^|[^\\\\])(?:\\\\.)*)" + O + "+$", "g"),
        F = new RegExp("^" + O + "*," + O + "*"),
        I = new RegExp("^" + O + "*([\\x20\\t\\r\\n\\f>+~])" + O + "*"),
        q = new RegExp(H),
        R = /^(?:#([\w\-]+)|(\w+)|\.([\w\-]+))$/,
        U = /^:not/,
        z = /[\x20\t\r\n\f]*[+~]/,
        W = /:not\($/,
        X = /h\d/i,
        V = /input|select|textarea|button/i,
        $ = /\\(?!\\)/g,
        J = {
          ID: new RegExp("^#(" + M + ")"),
          CLASS: new RegExp("^\\.(" + M + ")"),
          NAME: new RegExp("^\\[name=['\"]?(" + M + ")['\"]?\\]"),
          TAG: new RegExp("^(" + M.replace("w", "w*") + ")"),
          ATTR: new RegExp("^" + P),
          PSEUDO: new RegExp("^" + H),
          POS: new RegExp(B, "i"),
          CHILD: new RegExp("^:(only|nth|first|last)-child(?:\\(" + O + "*(even|odd|(([+-]|)(\\d*)n|)" + O + "*(?:([+-]|)" + O + "*(\\d+)|))" + O + "*\\)|)", "i"),
          needsContext: new RegExp("^" + O + "*[>+~]|" + B, "i")
        },
        K = function(e) {
          var t = g.createElement("div");
          try {
            return e(t)
          } catch (n) {
            return !1
          } finally {
            t = null
          }
        },
        Q = K(function(e) {
          return e.appendChild(g.createComment("")), !e.getElementsByTagName("*").length
        }),
        G = K(function(e) {
          return e.innerHTML = "<a href='#'></a>", e.firstChild && typeof e.firstChild.getAttribute !== p && e.firstChild.getAttribute("href") === "#"
        }),
        Y = K(function(e) {
          e.innerHTML = "<select></select>";
          var t = typeof e.lastChild.getAttribute("multiple");
          return t !== "boolean" && t !== "string"
        }),
        Z = K(function(e) {
          return e.innerHTML = "<div class='hidden e'></div><div class='hidden'></div>", !e.getElementsByClassName || !e.getElementsByClassName("e").length ? !1 : (e.lastChild.className = "e", e.getElementsByClassName("e").length === 2)
        }),
        et = K(function(e) {
          e.id = d + 0, e.innerHTML = "<a name='" + d + "'></a><div name='" + d + "'></div>", y.insertBefore(e, y.firstChild);
          var t = g.getElementsByName && g.getElementsByName(d).length === 2 + g.getElementsByName(d + 0).length;
          return r = !g.getElementById(d), y.removeChild(e), t
        });
      try {
        x.call(y.childNodes, 0)[0].nodeType
      } catch (tt) {
        x = function(e) {
          var t, n = [];
          for (; t = this[e]; e++)
            n.push(t);
          return n
        }
      }
      nt.matches = function(e, t) {
        return nt(e, null, null, t)
      }, nt.matchesSelector = function(e, t) {
        return nt(t, null, null, [e]).length > 0
      }, s = nt.getText = function(e) {
        var t, n = "",
          r = 0,
          i = e.nodeType;
        if (i) {
          if (i === 1 || i === 9 || i === 11) {
            if (typeof e.textContent == "string")
              return e.textContent;
            for (e = e.firstChild; e; e = e.nextSibling)
              n += s(e)
          } else if (i === 3 || i === 4)
            return e.nodeValue
        } else
          for (; t = e[r]; r++)
            n += s(t);
        return n
      }, o = nt.isXML = function(e) {
        var t = e && (e.ownerDocument || e).documentElement;
        return t ? t.nodeName !== "HTML" : !1
      }, u = nt.contains = y.contains ? function(e, t) {
        var n = e.nodeType === 9 ? e.documentElement : e,
          r = t && t.parentNode;
        return e === r || !!(r && r.nodeType === 1 && n.contains && n.contains(r))
      } : y.compareDocumentPosition ? function(e, t) {
        return t && !!(e.compareDocumentPosition(t) & 16)
      } : function(e, t) {
        while (t = t.parentNode)
          if (t === e)
            return !0;
        return !1
      }, nt.attr = function(e, t) {
        var n, r = o(e);
        return r || (t = t.toLowerCase()), (n = i.attrHandle[t]) ? n(e) : r || Y ? e.getAttribute(t) : (n = e.getAttributeNode(t), n ? typeof e[t] == "boolean" ? e[t] ? t : null : n.specified ? n.value : null : null)
      }, i = nt.selectors = {
        cacheLength: 50,
        createPseudo: N,
        match: J,
        attrHandle: G ? {} : {
          href: function(e) {
            return e.getAttribute("href", 2)
          },
          type: function(e) {
            return e.getAttribute("type")
          }
        },
        find: {
          ID: r ? function(e, t, n) {
            if (typeof t.getElementById !== p && !n) {
              var r = t.getElementById(e);
              return r && r.parentNode ? [r] : []
            }
          } : function(e, n, r) {
            if (typeof n.getElementById !== p && !r) {
              var i = n.getElementById(e);
              return i ? i.id === e || typeof i.getAttributeNode !== p && i.getAttributeNode("id").value === e ? [i] : t : []
            }
          },
          TAG: Q ? function(e, t) {
            if (typeof t.getElementsByTagName !== p)
              return t.getElementsByTagName(e)
          } : function(e, t) {
            var n = t.getElementsByTagName(e);
            if (e === "*") {
              var r, i = [],
                s = 0;
              for (; r = n[s]; s++)
                r.nodeType === 1 && i.push(r);
              return i
            }
            return n
          },
          NAME: et && function(e, t) {
            if (typeof t.getElementsByName !== p)
              return t.getElementsByName(name)
          },
          CLASS: Z && function(e, t, n) {
            if (typeof t.getElementsByClassName !== p && !n)
              return t.getElementsByClassName(e)
          }
        },
        relative: {
          ">": {
            dir: "parentNode",
            first: !0
          },
          " ": {
            dir: "parentNode"
          },
          "+": {
            dir: "previousSibling",
            first: !0
          },
          "~": {
            dir: "previousSibling"
          }
        },
        preFilter: {
          ATTR: function(e) {
            return e[1] = e[1].replace($, ""), e[3] = (e[4] || e[5] || "").replace($, ""), e[2] === "~=" && (e[3] = " " + e[3] + " "), e.slice(0, 4)
          },
          CHILD: function(e) {
            return e[1] = e[1].toLowerCase(), e[1] === "nth" ? (e[2] || nt.error(e[0]), e[3] = +(e[3] ? e[4] + (e[5] || 1) : 2 * (e[2] === "even" || e[2] === "odd")), e[4] = +(e[6] + e[7] || e[2] === "odd")) : e[2] && nt.error(e[0]), e
          },
          PSEUDO: function(e) {
            var t, n;
            if (J.CHILD.test(e[0]))
              return null;
            if (e[3])
              e[2] = e[3];
            else if (t = e[4])
              q.test(t) && (n = ut(t, !0)) && (n = t.indexOf(")", t.length - n) - t.length) && (t = t.slice(0, n), e[0] = e[0].slice(0, n)), e[2] = t;
            return e.slice(0, 3)
          }
        },
        filter: {
          ID: r ? function(e) {
            return e = e.replace($, ""),
              function(t) {
                return t.getAttribute("id") === e
              }
          } : function(e) {
            return e = e.replace($, ""),
              function(t) {
                var n = typeof t.getAttributeNode !== p && t.getAttributeNode("id");
                return n && n.value === e
              }
          },
          TAG: function(e) {
            return e === "*" ? function() {
              return !0
            } : (e = e.replace($, "").toLowerCase(), function(t) {
              return t.nodeName && t.nodeName.toLowerCase() === e
            })
          },
          CLASS: function(e) {
            var t = k[d][e + " "];
            return t || (t = new RegExp("(^|" + O + ")" + e + "(" + O + "|$)")) && k(e, function(e) {
              return t.test(e.className || typeof e.getAttribute !== p && e.getAttribute("class") || "")
            })
          },
          ATTR: function(e, t, n) {
            return function(r, i) {
              var s = nt.attr(r, e);
              return s == null ? t === "!=" : t ? (s += "", t === "=" ? s === n : t === "!=" ? s !== n : t === "^=" ? n && s.indexOf(n) === 0 : t === "*=" ? n && s.indexOf(n) > -1 : t === "$=" ? n && s.substr(s.length - n.length) === n : t === "~=" ? (" " + s + " ").indexOf(n) > -1 : t === "|=" ? s === n || s.substr(0, n.length + 1) === n + "-" : !1) : !0
            }
          },
          CHILD: function(e, t, n, r) {
            return e === "nth" ? function(e) {
              var t, i, s = e.parentNode;
              if (n === 1 && r === 0)
                return !0;
              if (s) {
                i = 0;
                for (t = s.firstChild; t; t = t.nextSibling)
                  if (t.nodeType === 1) {
                    i++;
                    if (e === t)
                      break
                  }
              }
              return i -= r, i === n || i % n === 0 && i / n >= 0
            } : function(t) {
              var n = t;
              switch (e) {
                case "only":
                case "first":
                  while (n = n.previousSibling)
                    if (n.nodeType === 1)
                      return !1;
                  if (e === "first")
                    return !0;
                  n = t;
                case "last":
                  while (n = n.nextSibling)
                    if (n.nodeType === 1)
                      return !1;
                  return !0
              }
            }
          },
          PSEUDO: function(e, t) {
            var n, r = i.pseudos[e] || i.setFilters[e.toLowerCase()] || nt.error("unsupported pseudo: " + e);
            return r[d] ? r(t) : r.length > 1 ? (n = [e, e, "", t], i.setFilters.hasOwnProperty(e.toLowerCase()) ? N(function(e, n) {
              var i, s = r(e, t),
                o = s.length;
              while (o--)
                i = T.call(e, s[o]), e[i] = !(n[i] = s[o])
            }) : function(e) {
              return r(e, 0, n)
            }) : r
          }
        },
        pseudos: {
          not: N(function(e) {
            var t = [],
              n = [],
              r = a(e.replace(j, "$1"));
            return r[d] ? N(function(e, t, n, i) {
              var s, o = r(e, null, i, []),
                u = e.length;
              while (u--)
                if (s = o[u])
                  e[u] = !(t[u] = s)
            }) : function(e, i, s) {
              return t[0] = e, r(t, null, s, n), !n.pop()
            }
          }),
          has: N(function(e) {
            return function(t) {
              return nt(e, t).length > 0
            }
          }),
          contains: N(function(e) {
            return function(t) {
              return (t.textContent || t.innerText || s(t)).indexOf(e) > -1
            }
          }),
          enabled: function(e) {
            return e.disabled === !1
          },
          disabled: function(e) {
            return e.disabled === !0
          },
          checked: function(e) {
            var t = e.nodeName.toLowerCase();
            return t === "input" && !!e.checked || t === "option" && !!e.selected
          },
          selected: function(e) {
            return e.parentNode && e.parentNode.selectedIndex, e.selected === !0
          },
          parent: function(e) {
            return !i.pseudos.empty(e)
          },
          empty: function(e) {
            var t;
            e = e.firstChild;
            while (e) {
              if (e.nodeName > "@" || (t = e.nodeType) === 3 || t === 4)
                return !1;
              e = e.nextSibling
            }
            return !0
          },
          header: function(e) {
            return X.test(e.nodeName)
          },
          text: function(e) {
            var t, n;
            return e.nodeName.toLowerCase() === "input" && (t = e.type) === "text" && ((n = e.getAttribute("type")) == null || n.toLowerCase() === t)
          },
          radio: rt("radio"),
          checkbox: rt("checkbox"),
          file: rt("file"),
          password: rt("password"),
          image: rt("image"),
          submit: it("submit"),
          reset: it("reset"),
          button: function(e) {
            var t = e.nodeName.toLowerCase();
            return t === "input" && e.type === "button" || t === "button"
          },
          input: function(e) {
            return V.test(e.nodeName)
          },
          focus: function(e) {
            var t = e.ownerDocument;
            return e === t.activeElement && (!t.hasFocus || t.hasFocus()) && !!(e.type || e.href || ~e.tabIndex)
          },
          active: function(e) {
            return e === e.ownerDocument.activeElement
          },
          first: st(function() {
            return [0]
          }),
          last: st(function(e, t) {
            return [t - 1]
          }),
          eq: st(function(e, t, n) {
            return [n < 0 ? n + t : n]
          }),
          even: st(function(e, t) {
            for (var n = 0; n < t; n += 2)
              e.push(n);
            return e
          }),
          odd: st(function(e, t) {
            for (var n = 1; n < t; n += 2)
              e.push(n);
            return e
          }),
          lt: st(function(e, t, n) {
            for (var r = n < 0 ? n + t : n; --r >= 0;)
              e.push(r);
            return e
          }),
          gt: st(function(e, t, n) {
            for (var r = n < 0 ? n + t : n; ++r < t;)
              e.push(r);
            return e
          })
        }
      }, f = y.compareDocumentPosition ? function(e, t) {
        return e === t ? (l = !0, 0) : (!e.compareDocumentPosition || !t.compareDocumentPosition ? e.compareDocumentPosition : e.compareDocumentPosition(t) & 4) ? -1 : 1
      } : function(e, t) {
        if (e === t)
          return l = !0, 0;
        if (e.sourceIndex && t.sourceIndex)
          return e.sourceIndex - t.sourceIndex;
        var n, r, i = [],
          s = [],
          o = e.parentNode,
          u = t.parentNode,
          a = o;
        if (o === u)
          return ot(e, t);
        if (!o)
          return -1;
        if (!u)
          return 1;
        while (a)
          i.unshift(a), a = a.parentNode;
        a = u;
        while (a)
          s.unshift(a), a = a.parentNode;
        n = i.length, r = s.length;
        for (var f = 0; f < n && f < r; f++)
          if (i[f] !== s[f])
            return ot(i[f], s[f]);
        return f === n ? ot(e, s[f], -1) : ot(i[f], t, 1)
      }, [0, 0].sort(f), h = !l, nt.uniqueSort = function(e) {
        var t, n = [],
          r = 1,
          i = 0;
        l = h, e.sort(f);
        if (l) {
          for (; t = e[r]; r++)
            t === e[r - 1] && (i = n.push(r));
          while (i--)
            e.splice(n[i], 1)
        }
        return e
      }, nt.error = function(e) {
        throw new Error("Syntax error, unrecognized expression: " + e)
      }, a = nt.compile = function(e, t) {
        var n, r = [],
          i = [],
          s = A[d][e + " "];
        if (!s) {
          t || (t = ut(e)), n = t.length;
          while (n--)
            s = ht(t[n]), s[d] ? r.push(s) : i.push(s);
          s = A(e, pt(i, r))
        }
        return s
      }, g.querySelectorAll && function() {
        var e, t = vt,
          n = /'|\\/g,
          r = /\=[\x20\t\r\n\f]*([^'"\]]*)[\x20\t\r\n\f]*\]/g,
          i = [":focus"],
          s = [":active"],
          u = y.matchesSelector || y.mozMatchesSelector || y.webkitMatchesSelector || y.oMatchesSelector || y.msMatchesSelector;
        K(function(e) {
          e.innerHTML = "<select><option selected=''></option></select>", e.querySelectorAll("[selected]").length || i.push("\\[" + O + "*(?:checked|disabled|ismap|multiple|readonly|selected|value)"), e.querySelectorAll(":checked").length || i.push(":checked")
        }), K(function(e) {
          e.innerHTML = "<p test=''></p>", e.querySelectorAll("[test^='']").length && i.push("[*^$]=" + O + "*(?:\"\"|'')"), e.innerHTML = "<input type='hidden'>", e.querySelectorAll(":enabled").length || i.push(":enabled", ":disabled")
        }), i = new RegExp(i.join("|")), vt = function(e, r, s, o, u) {
          if (!o && !u && !i.test(e)) {
            var a, f, l = !0,
              c = d,
              h = r,
              p = r.nodeType === 9 && e;
            if (r.nodeType === 1 && r.nodeName.toLowerCase() !== "object") {
              a = ut(e), (l = r.getAttribute("id")) ? c = l.replace(n, "\\$&") : r.setAttribute("id", c), c = "[id='" + c + "'] ", f = a.length;
              while (f--)
                a[f] = c + a[f].join("");
              h = z.test(e) && r.parentNode || r, p = a.join(",")
            }
            if (p)
              try {
                return S.apply(s, x.call(h.querySelectorAll(p), 0)), s
              } catch (v) {} finally {
                l || r.removeAttribute("id")
              }
          }
          return t(e, r, s, o, u)
        }, u && (K(function(t) {
          e = u.call(t, "div");
          try {
            u.call(t, "[test!='']:sizzle"), s.push("!=", H)
          } catch (n) {}
        }), s = new RegExp(s.join("|")), nt.matchesSelector = function(t, n) {
          n = n.replace(r, "='$1']");
          if (!o(t) && !s.test(n) && !i.test(n))
            try {
              var a = u.call(t, n);
              if (a || e || t.document && t.document.nodeType !== 11)
                return a
            } catch (f) {}
          return nt(n, null, null, [t]).length > 0
        })
      }(), i.pseudos.nth = i.pseudos.eq, i.filters = mt.prototype = i.pseudos, i.setFilters = new mt, nt.attr = v.attr, v.find = nt, v.expr = nt.selectors, v.expr[":"] = v.expr.pseudos, v.unique = nt.uniqueSort, v.text = nt.getText, v.isXMLDoc = nt.isXML, v.contains = nt.contains
    }(e);
  var nt = /Until$/,
    rt = /^(?:parents|prev(?:Until|All))/,
    it = /^.[^:#\[\.,]*$/,
    st = v.expr.match.needsContext,
    ot = {
      children: !0,
      contents: !0,
      next: !0,
      prev: !0
    };
  v.fn.extend({
    find: function(e) {
      var t, n, r, i, s, o, u = this;
      if (typeof e != "string")
        return v(e).filter(function() {
          for (t = 0, n = u.length; t < n; t++)
            if (v.contains(u[t], this))
              return !0
        });
      o = this.pushStack("", "find", e);
      for (t = 0, n = this.length; t < n; t++) {
        r = o.length, v.find(e, this[t], o);
        if (t > 0)
          for (i = r; i < o.length; i++)
            for (s = 0; s < r; s++)
              if (o[s] === o[i]) {
                o.splice(i--, 1);
                break
              }
      }
      return o
    },
    has: function(e) {
      var t, n = v(e, this),
        r = n.length;
      return this.filter(function() {
        for (t = 0; t < r; t++)
          if (v.contains(this, n[t]))
            return !0
      })
    },
    not: function(e) {
      return this.pushStack(ft(this, e, !1), "not", e)
    },
    filter: function(e) {
      return this.pushStack(ft(this, e, !0), "filter", e)
    },
    is: function(e) {
      return !!e && (typeof e == "string" ? st.test(e) ? v(e, this.context).index(this[0]) >= 0 : v.filter(e, this).length > 0 : this.filter(e).length > 0)
    },
    closest: function(e, t) {
      var n, r = 0,
        i = this.length,
        s = [],
        o = st.test(e) || typeof e != "string" ? v(e, t || this.context) : 0;
      for (; r < i; r++) {
        n = this[r];
        while (n && n.ownerDocument && n !== t && n.nodeType !== 11) {
          if (o ? o.index(n) > -1 : v.find.matchesSelector(n, e)) {
            s.push(n);
            break
          }
          n = n.parentNode
        }
      }
      return s = s.length > 1 ? v.unique(s) : s, this.pushStack(s, "closest", e)
    },
    index: function(e) {
      return e ? typeof e == "string" ? v.inArray(this[0], v(e)) : v.inArray(e.jquery ? e[0] : e, this) : this[0] && this[0].parentNode ? this.prevAll().length : -1
    },
    add: function(e, t) {
      var n = typeof e == "string" ? v(e, t) : v.makeArray(e && e.nodeType ? [e] : e),
        r = v.merge(this.get(), n);
      return this.pushStack(ut(n[0]) || ut(r[0]) ? r : v.unique(r))
    },
    addBack: function(e) {
      return this.add(e == null ? this.prevObject : this.prevObject.filter(e))
    }
  }), v.fn.andSelf = v.fn.addBack, v.each({
    parent: function(e) {
      var t = e.parentNode;
      return t && t.nodeType !== 11 ? t : null
    },
    parents: function(e) {
      return v.dir(e, "parentNode")
    },
    parentsUntil: function(e, t, n) {
      return v.dir(e, "parentNode", n)
    },
    next: function(e) {
      return at(e, "nextSibling")
    },
    prev: function(e) {
      return at(e, "previousSibling")
    },
    nextAll: function(e) {
      return v.dir(e, "nextSibling")
    },
    prevAll: function(e) {
      return v.dir(e, "previousSibling")
    },
    nextUntil: function(e, t, n) {
      return v.dir(e, "nextSibling", n)
    },
    prevUntil: function(e, t, n) {
      return v.dir(e, "previousSibling", n)
    },
    siblings: function(e) {
      return v.sibling((e.parentNode || {}).firstChild, e)
    },
    children: function(e) {
      return v.sibling(e.firstChild)
    },
    contents: function(e) {
      return v.nodeName(e, "iframe") ? e.contentDocument || e.contentWindow.document : v.merge([], e.childNodes)
    }
  }, function(e, t) {
    v.fn[e] = function(n, r) {
      var i = v.map(this, t, n);
      return nt.test(e) || (r = n), r && typeof r == "string" && (i = v.filter(r, i)), i = this.length > 1 && !ot[e] ? v.unique(i) : i, this.length > 1 && rt.test(e) && (i = i.reverse()), this.pushStack(i, e, l.call(arguments).join(","))
    }
  }), v.extend({
    filter: function(e, t, n) {
      return n && (e = ":not(" + e + ")"), t.length === 1 ? v.find.matchesSelector(t[0], e) ? [t[0]] : [] : v.find.matches(e, t)
    },
    dir: function(e, n, r) {
      var i = [],
        s = e[n];
      while (s && s.nodeType !== 9 && (r === t || s.nodeType !== 1 || !v(s).is(r)))
        s.nodeType === 1 && i.push(s), s = s[n];
      return i
    },
    sibling: function(e, t) {
      var n = [];
      for (; e; e = e.nextSibling)
        e.nodeType === 1 && e !== t && n.push(e);
      return n
    }
  });
  var ct = "abbr|article|aside|audio|bdi|canvas|data|datalist|details|figcaption|figure|footer|header|hgroup|mark|meter|nav|output|progress|section|summary|time|video",
    ht = / jQuery\d+="(?:null|\d+)"/g,
    pt = /^\s+/,
    dt = /<(?!area|br|col|embed|hr|img|input|link|meta|param)(([\w:]+)[^>]*)\/>/gi,
    vt = /<([\w:]+)/,
    mt = /<tbody/i,
    gt = /<|&#?\w+;/,
    yt = /<(?:script|style|link)/i,
    bt = /<(?:script|object|embed|option|style)/i,
    wt = new RegExp("<(?:" + ct + ")[\\s/>]", "i"),
    Et = /^(?:checkbox|radio)$/,
    St = /checked\s*(?:[^=]|=\s*.checked.)/i,
    xt = /\/(java|ecma)script/i,
    Tt = /^\s*<!(?:\[CDATA\[|\-\-)|[\]\-]{2}>\s*$/g,
    Nt = {
      option: [1, "<select multiple='multiple'>", "</select>"],
      legend: [1, "<fieldset>", "</fieldset>"],
      thead: [1, "<table>", "</table>"],
      tr: [2, "<table><tbody>", "</tbody></table>"],
      td: [3, "<table><tbody><tr>", "</tr></tbody></table>"],
      col: [2, "<table><tbody></tbody><colgroup>", "</colgroup></table>"],
      area: [1, "<map>", "</map>"],
      _default: [0, "", ""]
    },
    Ct = lt(i),
    kt = Ct.appendChild(i.createElement("div"));
  Nt.optgroup = Nt.option, Nt.tbody = Nt.tfoot = Nt.colgroup = Nt.caption = Nt.thead, Nt.th = Nt.td, v.support.htmlSerialize || (Nt._default = [1, "X<div>", "</div>"]), v.fn.extend({
      text: function(e) {
        return v.access(this, function(e) {
          return e === t ? v.text(this) : this.empty().append((this[0] && this[0].ownerDocument || i).createTextNode(e))
        }, null, e, arguments.length)
      },
      wrapAll: function(e) {
        if (v.isFunction(e))
          return this.each(function(t) {
            v(this).wrapAll(e.call(this, t))
          });
        if (this[0]) {
          var t = v(e, this[0].ownerDocument).eq(0).clone(!0);
          this[0].parentNode && t.insertBefore(this[0]), t.map(function() {
            var e = this;
            while (e.firstChild && e.firstChild.nodeType === 1)
              e = e.firstChild;
            return e
          }).append(this)
        }
        return this
      },
      wrapInner: function(e) {
        return v.isFunction(e) ? this.each(function(t) {
          v(this).wrapInner(e.call(this, t))
        }) : this.each(function() {
          var t = v(this),
            n = t.contents();
          n.length ? n.wrapAll(e) : t.append(e)
        })
      },
      wrap: function(e) {
        var t = v.isFunction(e);
        return this.each(function(n) {
          v(this).wrapAll(t ? e.call(this, n) : e)
        })
      },
      unwrap: function() {
        return this.parent().each(function() {
          v.nodeName(this, "body") || v(this).replaceWith(this.childNodes)
        }).end()
      },
      append: function() {
        return this.domManip(arguments, !0, function(e) {
          (this.nodeType === 1 || this.nodeType === 11) && this.appendChild(e)
        })
      },
      prepend: function() {
        return this.domManip(arguments, !0, function(e) {
          (this.nodeType === 1 || this.nodeType === 11) && this.insertBefore(e, this.firstChild)
        })
      },
      before: function() {
        if (!ut(this[0]))
          return this.domManip(arguments, !1, function(e) {
            this.parentNode.insertBefore(e, this)
          });
        if (arguments.length) {
          var e = v.clean(arguments);
          return this.pushStack(v.merge(e, this), "before", this.selector)
        }
      },
      after: function() {
        if (!ut(this[0]))
          return this.domManip(arguments, !1, function(e) {
            this.parentNode.insertBefore(e, this.nextSibling)
          });
        if (arguments.length) {
          var e = v.clean(arguments);
          return this.pushStack(v.merge(this, e), "after", this.selector)
        }
      },
      remove: function(e, t) {
        var n, r = 0;
        for (;
          (n = this[r]) != null; r++)
          if (!e || v.filter(e, [n]).length) !t && n.nodeType === 1 && (v.cleanData(n.getElementsByTagName("*")), v.cleanData([n])), n.parentNode && n.parentNode.removeChild(n);
        return this
      },
      empty: function() {
        var e, t = 0;
        for (;
          (e = this[t]) != null; t++) {
          e.nodeType === 1 && v.cleanData(e.getElementsByTagName("*"));
          while (e.firstChild)
            e.removeChild(e.firstChild)
        }
        return this
      },
      clone: function(e, t) {
        return e = e == null ? !1 : e, t = t == null ? e : t, this.map(function() {
          return v.clone(this, e, t)
        })
      },
      html: function(e) {
        return v.access(this, function(e) {
          var n = this[0] || {},
            r = 0,
            i = this.length;
          if (e === t)
            return n.nodeType === 1 ? n.innerHTML.replace(ht, "") : t;
          if (typeof e == "string" && !yt.test(e) && (v.support.htmlSerialize || !wt.test(e)) && (v.support.leadingWhitespace || !pt.test(e)) && !Nt[(vt.exec(e) || ["", ""])[1].toLowerCase()]) {
            e = e.replace(dt, "<$1></$2>");
            try {
              for (; r < i; r++)
                n = this[r] || {}, n.nodeType === 1 && (v.cleanData(n.getElementsByTagName("*")), n.innerHTML = e);
              n = 0
            } catch (s) {}
          }
          n && this.empty().append(e)
        }, null, e, arguments.length)
      },
      replaceWith: function(e) {
        return ut(this[0]) ? this.length ? this.pushStack(v(v.isFunction(e) ? e() : e), "replaceWith", e) : this : v.isFunction(e) ? this.each(function(t) {
          var n = v(this),
            r = n.html();
          n.replaceWith(e.call(this, t, r))
        }) : (typeof e != "string" && (e = v(e).detach()), this.each(function() {
          var t = this.nextSibling,
            n = this.parentNode;
          v(this).remove(), t ? v(t).before(e) : v(n).append(e)
        }))
      },
      detach: function(e) {
        return this.remove(e, !0)
      },
      domManip: function(e, n, r) {
        e = [].concat.apply([], e);
        var i, s, o, u, a = 0,
          f = e[0],
          l = [],
          c = this.length;
        if (!v.support.checkClone && c > 1 && typeof f == "string" && St.test(f))
          return this.each(function() {
            v(this).domManip(e, n, r)
          });
        if (v.isFunction(f))
          return this.each(function(i) {
            var s = v(this);
            e[0] = f.call(this, i, n ? s.html() : t), s.domManip(e, n, r)
          });
        if (this[0]) {
          i = v.buildFragment(e, this, l), o = i.fragment, s = o.firstChild, o.childNodes.length === 1 && (o = s);
          if (s) {
            n = n && v.nodeName(s, "tr");
            for (u = i.cacheable || c - 1; a < c; a++)
              r.call(n && v.nodeName(this[a], "table") ? Lt(this[a], "tbody") : this[a], a === u ? o : v.clone(o, !0, !0))
          }
          o = s = null, l.length && v.each(l, function(e, t) {
            t.src ? v.ajax ? v.ajax({
              url: t.src,
              type: "GET",
              dataType: "script",
              async: !1,
              global: !1,
              "throws": !0
            }) : v.error("no ajax") : v.globalEval((t.text || t.textContent || t.innerHTML || "").replace(Tt, "")), t.parentNode && t.parentNode.removeChild(t)
          })
        }
        return this
      }
    }), v.buildFragment = function(e, n, r) {
      var s, o, u, a = e[0];
      return n = n || i, n = !n.nodeType && n[0] || n, n = n.ownerDocument || n, e.length === 1 && typeof a == "string" && a.length < 512 && n === i && a.charAt(0) === "<" && !bt.test(a) && (v.support.checkClone || !St.test(a)) && (v.support.html5Clone || !wt.test(a)) && (o = !0, s = v.fragments[a], u = s !== t), s || (s = n.createDocumentFragment(), v.clean(e, n, s, r), o && (v.fragments[a] = u && s)), {
        fragment: s,
        cacheable: o
      }
    }, v.fragments = {}, v.each({
      appendTo: "append",
      prependTo: "prepend",
      insertBefore: "before",
      insertAfter: "after",
      replaceAll: "replaceWith"
    }, function(e, t) {
      v.fn[e] = function(n) {
        var r, i = 0,
          s = [],
          o = v(n),
          u = o.length,
          a = this.length === 1 && this[0].parentNode;
        if ((a == null || a && a.nodeType === 11 && a.childNodes.length === 1) && u === 1)
          return o[t](this[0]), this;
        for (; i < u; i++)
          r = (i > 0 ? this.clone(!0) : this).get(), v(o[i])[t](r), s = s.concat(r);
        return this.pushStack(s, e, o.selector)
      }
    }), v.extend({
      clone: function(e, t, n) {
        var r, i, s, o;
        v.support.html5Clone || v.isXMLDoc(e) || !wt.test("<" + e.nodeName + ">") ? o = e.cloneNode(!0) : (kt.innerHTML = e.outerHTML, kt.removeChild(o = kt.firstChild));
        if ((!v.support.noCloneEvent || !v.support.noCloneChecked) && (e.nodeType === 1 || e.nodeType === 11) && !v.isXMLDoc(e)) {
          Ot(e, o), r = Mt(e), i = Mt(o);
          for (s = 0; r[s]; ++s)
            i[s] && Ot(r[s], i[s])
        }
        if (t) {
          At(e, o);
          if (n) {
            r = Mt(e), i = Mt(o);
            for (s = 0; r[s]; ++s)
              At(r[s], i[s])
          }
        }
        return r = i = null, o
      },
      clean: function(e, t, n, r) {
        var s, o, u, a, f, l, c, h, p, d, m, g, y = t === i && Ct,
          b = [];
        if (!t || typeof t.createDocumentFragment == "undefined")
          t = i;
        for (s = 0;
          (u = e[s]) != null; s++) {
          typeof u == "number" && (u += "");
          if (!u)
            continue;
          if (typeof u == "string")
            if (!gt.test(u))
              u = t.createTextNode(u);
            else {
              y = y || lt(t), c = t.createElement("div"), y.appendChild(c), u = u.replace(dt, "<$1></$2>"), a = (vt.exec(u) || ["", ""])[1].toLowerCase(), f = Nt[a] || Nt._default, l = f[0], c.innerHTML = f[1] + u + f[2];
              while (l--)
                c = c.lastChild;
              if (!v.support.tbody) {
                h = mt.test(u), p = a === "table" && !h ? c.firstChild && c.firstChild.childNodes : f[1] === "<table>" && !h ? c.childNodes : [];
                for (o = p.length - 1; o >= 0; --o)
                  v.nodeName(p[o], "tbody") && !p[o].childNodes.length && p[o].parentNode.removeChild(p[o])
              }!v.support.leadingWhitespace && pt.test(u) && c.insertBefore(t.createTextNode(pt.exec(u)[0]), c.firstChild), u = c.childNodes, c.parentNode.removeChild(c)
            }
          u.nodeType ? b.push(u) : v.merge(b, u)
        }
        c && (u = c = y = null);
        if (!v.support.appendChecked)
          for (s = 0;
            (u = b[s]) != null; s++)
            v.nodeName(u, "input") ? _t(u) : typeof u.getElementsByTagName != "undefined" && v.grep(u.getElementsByTagName("input"), _t);
        if (n) {
          m = function(e) {
            if (!e.type || xt.test(e.type))
              return r ? r.push(e.parentNode ? e.parentNode.removeChild(e) : e) : n.appendChild(e)
          };
          for (s = 0;
            (u = b[s]) != null; s++)
            if (!v.nodeName(u, "script") || !m(u))
              n.appendChild(u), typeof u.getElementsByTagName != "undefined" && (g = v.grep(v.merge([], u.getElementsByTagName("script")), m), b.splice.apply(b, [s + 1, 0].concat(g)), s += g.length)
        }
        return b
      },
      cleanData: function(e, t) {
        var n, r, i, s, o = 0,
          u = v.expando,
          a = v.cache,
          f = v.support.deleteExpando,
          l = v.event.special;
        for (;
          (i = e[o]) != null; o++)
          if (t || v.acceptData(i)) {
            r = i[u], n = r && a[r];
            if (n) {
              if (n.events)
                for (s in n.events)
                  l[s] ? v.event.remove(i, s) : v.removeEvent(i, s, n.handle);
              a[r] && (delete a[r], f ? delete i[u] : i.removeAttribute ? i.removeAttribute(u) : i[u] = null, v.deletedIds.push(r))
            }
          }
      }
    }),
    function() {
      var e, t;
      v.uaMatch = function(e) {
        e = e.toLowerCase();
        var t = /(chrome)[ \/]([\w.]+)/.exec(e) || /(webkit)[ \/]([\w.]+)/.exec(e) || /(opera)(?:.*version|)[ \/]([\w.]+)/.exec(e) || /(msie) ([\w.]+)/.exec(e) || e.indexOf("compatible") < 0 && /(mozilla)(?:.*? rv:([\w.]+)|)/.exec(e) || [];
        return {
          browser: t[1] || "",
          version: t[2] || "0"
        }
      }, e = v.uaMatch(o.userAgent), t = {}, e.browser && (t[e.browser] = !0, t.version = e.version), t.chrome ? t.webkit = !0 : t.webkit && (t.safari = !0), v.browser = t, v.sub = function() {
        function e(t, n) {
          return new e.fn.init(t, n)
        }
        v.extend(!0, e, this), e.superclass = this, e.fn = e.prototype = this(), e.fn.constructor = e, e.sub = this.sub, e.fn.init = function(r, i) {
          return i && i instanceof v && !(i instanceof e) && (i = e(i)), v.fn.init.call(this, r, i, t)
        }, e.fn.init.prototype = e.fn;
        var t = e(i);
        return e
      }
    }();
  var Dt, Pt, Ht, Bt = /alpha\([^)]*\)/i,
    jt = /opacity=([^)]*)/,
    Ft = /^(top|right|bottom|left)$/,
    It = /^(none|table(?!-c[ea]).+)/,
    qt = /^margin/,
    Rt = new RegExp("^(" + m + ")(.*)$", "i"),
    Ut = new RegExp("^(" + m + ")(?!px)[a-z%]+$", "i"),
    zt = new RegExp("^([-+])=(" + m + ")", "i"),
    Wt = {
      BODY: "block"
    },
    Xt = {
      position: "absolute",
      visibility: "hidden",
      display: "block"
    },
    Vt = {
      letterSpacing: 0,
      fontWeight: 400
    },
    $t = ["Top", "Right", "Bottom", "Left"],
    Jt = ["Webkit", "O", "Moz", "ms"],
    Kt = v.fn.toggle;
  v.fn.extend({
    css: function(e, n) {
      return v.access(this, function(e, n, r) {
        return r !== t ? v.style(e, n, r) : v.css(e, n)
      }, e, n, arguments.length > 1)
    },
    show: function() {
      return Yt(this, !0)
    },
    hide: function() {
      return Yt(this)
    },
    toggle: function(e, t) {
      var n = typeof e == "boolean";
      return v.isFunction(e) && v.isFunction(t) ? Kt.apply(this, arguments) : this.each(function() {
        (n ? e : Gt(this)) ? v(this).show(): v(this).hide()
      })
    }
  }), v.extend({
    cssHooks: {
      opacity: {
        get: function(e, t) {
          if (t) {
            var n = Dt(e, "opacity");
            return n === "" ? "1" : n
          }
        }
      }
    },
    cssNumber: {
      fillOpacity: !0,
      fontWeight: !0,
      lineHeight: !0,
      opacity: !0,
      orphans: !0,
      widows: !0,
      zIndex: !0,
      zoom: !0
    },
    cssProps: {
      "float": v.support.cssFloat ? "cssFloat" : "styleFloat"
    },
    style: function(e, n, r, i) {
      if (!e || e.nodeType === 3 || e.nodeType === 8 || !e.style)
        return;
      var s, o, u, a = v.camelCase(n),
        f = e.style;
      n = v.cssProps[a] || (v.cssProps[a] = Qt(f, a)), u = v.cssHooks[n] || v.cssHooks[a];
      if (r === t)
        return u && "get" in u && (s = u.get(e, !1, i)) !== t ? s : f[n];
      o = typeof r, o === "string" && (s = zt.exec(r)) && (r = (s[1] + 1) * s[2] + parseFloat(v.css(e, n)), o = "number");
      if (r == null || o === "number" && isNaN(r))
        return;
      o === "number" && !v.cssNumber[a] && (r += "px");
      if (!u || !("set" in u) || (r = u.set(e, r, i)) !== t)
        try {
          f[n] = r
        } catch (l) {}
    },
    css: function(e, n, r, i) {
      var s, o, u, a = v.camelCase(n);
      return n = v.cssProps[a] || (v.cssProps[a] = Qt(e.style, a)), u = v.cssHooks[n] || v.cssHooks[a], u && "get" in u && (s = u.get(e, !0, i)), s === t && (s = Dt(e, n)), s === "normal" && n in Vt && (s = Vt[n]), r || i !== t ? (o = parseFloat(s), r || v.isNumeric(o) ? o || 0 : s) : s
    },
    swap: function(e, t, n) {
      var r, i, s = {};
      for (i in t)
        s[i] = e.style[i], e.style[i] = t[i];
      r = n.call(e);
      for (i in t)
        e.style[i] = s[i];
      return r
    }
  }), e.getComputedStyle ? Dt = function(t, n) {
    var r, i, s, o, u = e.getComputedStyle(t, null),
      a = t.style;
    return u && (r = u.getPropertyValue(n) || u[n], r === "" && !v.contains(t.ownerDocument, t) && (r = v.style(t, n)), Ut.test(r) && qt.test(n) && (i = a.width, s = a.minWidth, o = a.maxWidth, a.minWidth = a.maxWidth = a.width = r, r = u.width, a.width = i, a.minWidth = s, a.maxWidth = o)), r
  } : i.documentElement.currentStyle && (Dt = function(e, t) {
    var n, r, i = e.currentStyle && e.currentStyle[t],
      s = e.style;
    return i == null && s && s[t] && (i = s[t]), Ut.test(i) && !Ft.test(t) && (n = s.left, r = e.runtimeStyle && e.runtimeStyle.left, r && (e.runtimeStyle.left = e.currentStyle.left), s.left = t === "fontSize" ? "1em" : i, i = s.pixelLeft + "px", s.left = n, r && (e.runtimeStyle.left = r)), i === "" ? "auto" : i
  }), v.each(["height", "width"], function(e, t) {
    v.cssHooks[t] = {
      get: function(e, n, r) {
        if (n)
          return e.offsetWidth === 0 && It.test(Dt(e, "display")) ? v.swap(e, Xt, function() {
            return tn(e, t, r)
          }) : tn(e, t, r)
      },
      set: function(e, n, r) {
        return Zt(e, n, r ? en(e, t, r, v.support.boxSizing && v.css(e, "boxSizing") === "border-box") : 0)
      }
    }
  }), v.support.opacity || (v.cssHooks.opacity = {
    get: function(e, t) {
      return jt.test((t && e.currentStyle ? e.currentStyle.filter : e.style.filter) || "") ? .01 * parseFloat(RegExp.$1) + "" : t ? "1" : ""
    },
    set: function(e, t) {
      var n = e.style,
        r = e.currentStyle,
        i = v.isNumeric(t) ? "alpha(opacity=" + t * 100 + ")" : "",
        s = r && r.filter || n.filter || "";
      n.zoom = 1;
      if (t >= 1 && v.trim(s.replace(Bt, "")) === "" && n.removeAttribute) {
        n.removeAttribute("filter");
        if (r && !r.filter)
          return
      }
      n.filter = Bt.test(s) ? s.replace(Bt, i) : s + " " + i
    }
  }), v(function() {
    v.support.reliableMarginRight || (v.cssHooks.marginRight = {
      get: function(e, t) {
        return v.swap(e, {
          display: "inline-block"
        }, function() {
          if (t)
            return Dt(e, "marginRight")
        })
      }
    }), !v.support.pixelPosition && v.fn.position && v.each(["top", "left"], function(e, t) {
      v.cssHooks[t] = {
        get: function(e, n) {
          if (n) {
            var r = Dt(e, t);
            return Ut.test(r) ? v(e).position()[t] + "px" : r
          }
        }
      }
    })
  }), v.expr && v.expr.filters && (v.expr.filters.hidden = function(e) {
    return e.offsetWidth === 0 && e.offsetHeight === 0 || !v.support.reliableHiddenOffsets && (e.style && e.style.display || Dt(e, "display")) === "none"
  }, v.expr.filters.visible = function(e) {
    return !v.expr.filters.hidden(e)
  }), v.each({
    margin: "",
    padding: "",
    border: "Width"
  }, function(e, t) {
    v.cssHooks[e + t] = {
      expand: function(n) {
        var r, i = typeof n == "string" ? n.split(" ") : [n],
          s = {};
        for (r = 0; r < 4; r++)
          s[e + $t[r] + t] = i[r] || i[r - 2] || i[0];
        return s
      }
    }, qt.test(e) || (v.cssHooks[e + t].set = Zt)
  });
  var rn = /%20/g,
    sn = /\[\]$/,
    on = /\r?\n/g,
    un = /^(?:color|date|datetime|datetime-local|email|hidden|month|number|password|range|search|tel|text|time|url|week)$/i,
    an = /^(?:select|textarea)/i;
  v.fn.extend({
    serialize: function() {
      return v.param(this.serializeArray())
    },
    serializeArray: function() {
      return this.map(function() {
        return this.elements ? v.makeArray(this.elements) : this
      }).filter(function() {
        return this.name && !this.disabled && (this.checked || an.test(this.nodeName) || un.test(this.type))
      }).map(function(e, t) {
        var n = v(this).val();
        return n == null ? null : v.isArray(n) ? v.map(n, function(e, n) {
          return {
            name: t.name,
            value: e.replace(on, "\r\n")
          }
        }) : {
          name: t.name,
          value: n.replace(on, "\r\n")
        }
      }).get()
    }
  }), v.param = function(e, n) {
    var r, i = [],
      s = function(e, t) {
        t = v.isFunction(t) ? t() : t == null ? "" : t, i[i.length] = encodeURIComponent(e) + "=" + encodeURIComponent(t)
      };
    n === t && (n = v.ajaxSettings && v.ajaxSettings.traditional);
    if (v.isArray(e) || e.jquery && !v.isPlainObject(e))
      v.each(e, function() {
        s(this.name, this.value)
      });
    else
      for (r in e)
        fn(r, e[r], n, s);
    return i.join("&").replace(rn, "+")
  };
  var ln, cn, hn = /#.*$/,
    pn = /^(.*?):[ \t]*([^\r\n]*)\r?$/mg,
    dn = /^(?:about|app|app\-storage|.+\-extension|file|res|widget):$/,
    vn = /^(?:GET|HEAD)$/,
    mn = /^\/\//,
    gn = /\?/,
    yn = /<script\b[^<]*(?:(?!<\/script>)<[^<]*)*<\/script>/gi,
    bn = /([?&])_=[^&]*/,
    wn = /^([\w\+\.\-]+:)(?:\/\/([^\/?#:]*)(?::(\d+)|)|)/,
    En = v.fn.load,
    Sn = {},
    xn = {},
    Tn = ["*/"] + ["*"];
  try {
    cn = s.href
  } catch (Nn) {
    cn = i.createElement("a"), cn.href = "", cn = cn.href
  }
  ln = wn.exec(cn.toLowerCase()) || [], v.fn.load = function(e, n, r) {
    if (typeof e != "string" && En)
      return En.apply(this, arguments);
    if (!this.length)
      return this;
    var i, s, o, u = this,
      a = e.indexOf(" ");
    return a >= 0 && (i = e.slice(a, e.length), e = e.slice(0, a)), v.isFunction(n) ? (r = n, n = t) : n && typeof n == "object" && (s = "POST"), v.ajax({
      url: e,
      type: s,
      dataType: "html",
      data: n,
      complete: function(e, t) {
        r && u.each(r, o || [e.responseText, t, e])
      }
    }).done(function(e) {
      o = arguments, u.html(i ? v("<div>").append(e.replace(yn, "")).find(i) : e)
    }), this
  }, v.each("ajaxStart ajaxStop ajaxComplete ajaxError ajaxSuccess ajaxSend".split(" "), function(e, t) {
    v.fn[t] = function(e) {
      return this.on(t, e)
    }
  }), v.each(["get", "post"], function(e, n) {
    v[n] = function(e, r, i, s) {
      return v.isFunction(r) && (s = s || i, i = r, r = t), v.ajax({
        type: n,
        url: e,
        data: r,
        success: i,
        dataType: s
      })
    }
  }), v.extend({
    getScript: function(e, n) {
      return v.get(e, t, n, "script")
    },
    getJSON: function(e, t, n) {
      return v.get(e, t, n, "json")
    },
    ajaxSetup: function(e, t) {
      return t ? Ln(e, v.ajaxSettings) : (t = e, e = v.ajaxSettings), Ln(e, t), e
    },
    ajaxSettings: {
      url: cn,
      isLocal: dn.test(ln[1]),
      global: !0,
      type: "GET",
      contentType: "application/x-www-form-urlencoded; charset=UTF-8",
      processData: !0,
      async: !0,
      accepts: {
        xml: "application/xml, text/xml",
        html: "text/html",
        text: "text/plain",
        json: "application/json, text/javascript",
        "*": Tn
      },
      contents: {
        xml: /xml/,
        html: /html/,
        json: /json/
      },
      responseFields: {
        xml: "responseXML",
        text: "responseText"
      },
      converters: {
        "* text": e.String,
        "text html": !0,
        "text json": v.parseJSON,
        "text xml": v.parseXML
      },
      flatOptions: {
        context: !0,
        url: !0
      }
    },
    ajaxPrefilter: Cn(Sn),
    ajaxTransport: Cn(xn),
    ajax: function(e, n) {
      function T(e, n, s, a) {
        var l, y, b, w, S, T = n;
        if (E === 2)
          return;
        E = 2, u && clearTimeout(u), o = t, i = a || "", x.readyState = e > 0 ? 4 : 0, s && (w = An(c, x, s));
        if (e >= 200 && e < 300 || e === 304)
          c.ifModified && (S = x.getResponseHeader("Last-Modified"), S && (v.lastModified[r] = S), S = x.getResponseHeader("Etag"), S && (v.etag[r] = S)), e === 304 ? (T = "notmodified", l = !0) : (l = On(c, w), T = l.state, y = l.data, b = l.error, l = !b);
        else {
          b = T;
          if (!T || e)
            T = "error", e < 0 && (e = 0)
        }
        x.status = e, x.statusText = (n || T) + "", l ? d.resolveWith(h, [y, T, x]) : d.rejectWith(h, [x, T, b]), x.statusCode(g), g = t, f && p.trigger("ajax" + (l ? "Success" : "Error"), [x, c, l ? y : b]), m.fireWith(h, [x, T]), f && (p.trigger("ajaxComplete", [x, c]), --v.active || v.event.trigger("ajaxStop"))
      }
      typeof e == "object" && (n = e, e = t), n = n || {};
      var r, i, s, o, u, a, f, l, c = v.ajaxSetup({}, n),
        h = c.context || c,
        p = h !== c && (h.nodeType || h instanceof v) ? v(h) : v.event,
        d = v.Deferred(),
        m = v.Callbacks("once memory"),
        g = c.statusCode || {},
        b = {},
        w = {},
        E = 0,
        S = "canceled",
        x = {
          readyState: 0,
          setRequestHeader: function(e, t) {
            if (!E) {
              var n = e.toLowerCase();
              e = w[n] = w[n] || e, b[e] = t
            }
            return this
          },
          getAllResponseHeaders: function() {
            return E === 2 ? i : null
          },
          getResponseHeader: function(e) {
            var n;
            if (E === 2) {
              if (!s) {
                s = {};
                while (n = pn.exec(i))
                  s[n[1].toLowerCase()] = n[2]
              }
              n = s[e.toLowerCase()]
            }
            return n === t ? null : n
          },
          overrideMimeType: function(e) {
            return E || (c.mimeType = e), this
          },
          abort: function(e) {
            return e = e || S, o && o.abort(e), T(0, e), this
          }
        };
      d.promise(x), x.success = x.done, x.error = x.fail, x.complete = m.add, x.statusCode = function(e) {
        if (e) {
          var t;
          if (E < 2)
            for (t in e)
              g[t] = [g[t], e[t]];
          else
            t = e[x.status], x.always(t)
        }
        return this
      }, c.url = ((e || c.url) + "").replace(hn, "").replace(mn, ln[1] + "//"), c.dataTypes = v.trim(c.dataType || "*").toLowerCase().split(y), c.crossDomain == null && (a = wn.exec(c.url.toLowerCase()), c.crossDomain = !(!a || a[1] === ln[1] && a[2] === ln[2] && (a[3] || (a[1] === "http:" ? 80 : 443)) == (ln[3] || (ln[1] === "http:" ? 80 : 443)))), c.data && c.processData && typeof c.data != "string" && (c.data = v.param(c.data, c.traditional)), kn(Sn, c, n, x);
      if (E === 2)
        return x;
      f = c.global, c.type = c.type.toUpperCase(), c.hasContent = !vn.test(c.type), f && v.active++ === 0 && v.event.trigger("ajaxStart");
      if (!c.hasContent) {
        c.data && (c.url += (gn.test(c.url) ? "&" : "?") + c.data, delete c.data), r = c.url;
        if (c.cache === !1) {
          var N = v.now(),
            C = c.url.replace(bn, "$1_=" + N);
          c.url = C + (C === c.url ? (gn.test(c.url) ? "&" : "?") + "_=" + N : "")
        }
      }(c.data && c.hasContent && c.contentType !== !1 || n.contentType) && x.setRequestHeader("Content-Type", c.contentType), c.ifModified && (r = r || c.url, v.lastModified[r] && x.setRequestHeader("If-Modified-Since", v.lastModified[r]), v.etag[r] && x.setRequestHeader("If-None-Match", v.etag[r])), x.setRequestHeader("Accept", c.dataTypes[0] && c.accepts[c.dataTypes[0]] ? c.accepts[c.dataTypes[0]] + (c.dataTypes[0] !== "*" ? ", " + Tn + "; q=0.01" : "") : c.accepts["*"]);
      for (l in c.headers)
        x.setRequestHeader(l, c.headers[l]);
      if (!c.beforeSend || c.beforeSend.call(h, x, c) !== !1 && E !== 2) {
        S = "abort";
        for (l in {
            success: 1,
            error: 1,
            complete: 1
          })
          x[l](c[l]);
        o = kn(xn, c, n, x);
        if (!o)
          T(-1, "No Transport");
        else {
          x.readyState = 1, f && p.trigger("ajaxSend", [x, c]), c.async && c.timeout > 0 && (u = setTimeout(function() {
            x.abort("timeout")
          }, c.timeout));
          try {
            E = 1, o.send(b, T)
          } catch (k) {
            if (!(E < 2))
              throw k;
            T(-1, k)
          }
        }
        return x
      }
      return x.abort()
    },
    active: 0,
    lastModified: {},
    etag: {}
  });
  var Mn = [],
    _n = /\?/,
    Dn = /(=)\?(?=&|$)|\?\?/,
    Pn = v.now();
  v.ajaxSetup({
    jsonp: "callback",
    jsonpCallback: function() {
      var e = Mn.pop() || v.expando + "_" + Pn++;
      return this[e] = !0, e
    }
  }), v.ajaxPrefilter("json jsonp", function(n, r, i) {
    var s, o, u, a = n.data,
      f = n.url,
      l = n.jsonp !== !1,
      c = l && Dn.test(f),
      h = l && !c && typeof a == "string" && !(n.contentType || "").indexOf("application/x-www-form-urlencoded") && Dn.test(a);
    if (n.dataTypes[0] === "jsonp" || c || h)
      return s = n.jsonpCallback = v.isFunction(n.jsonpCallback) ? n.jsonpCallback() : n.jsonpCallback, o = e[s], c ? n.url = f.replace(Dn, "$1" + s) : h ? n.data = a.replace(Dn, "$1" + s) : l && (n.url += (_n.test(f) ? "&" : "?") + n.jsonp + "=" + s), n.converters["script json"] = function() {
        return u || v.error(s + " was not called"), u[0]
      }, n.dataTypes[0] = "json", e[s] = function() {
        u = arguments
      }, i.always(function() {
        e[s] = o, n[s] && (n.jsonpCallback = r.jsonpCallback, Mn.push(s)), u && v.isFunction(o) && o(u[0]), u = o = t
      }), "script"
  }), v.ajaxSetup({
    accepts: {
      script: "text/javascript, application/javascript, application/ecmascript, application/x-ecmascript"
    },
    contents: {
      script: /javascript|ecmascript/
    },
    converters: {
      "text script": function(e) {
        return v.globalEval(e), e
      }
    }
  }), v.ajaxPrefilter("script", function(e) {
    e.cache === t && (e.cache = !1), e.crossDomain && (e.type = "GET", e.global = !1)
  }), v.ajaxTransport("script", function(e) {
    if (e.crossDomain) {
      var n, r = i.head || i.getElementsByTagName("head")[0] || i.documentElement;
      return {
        send: function(s, o) {
          n = i.createElement("script"), n.async = "async", e.scriptCharset && (n.charset = e.scriptCharset), n.src = e.url, n.onload = n.onreadystatechange = function(e, i) {
            if (i || !n.readyState || /loaded|complete/.test(n.readyState))
              n.onload = n.onreadystatechange = null, r && n.parentNode && r.removeChild(n), n = t, i || o(200, "success")
          }, r.insertBefore(n, r.firstChild)
        },
        abort: function() {
          n && n.onload(0, 1)
        }
      }
    }
  });
  var Hn, Bn = e.ActiveXObject ? function() {
      for (var e in Hn)
        Hn[e](0, 1)
    } : !1,
    jn = 0;
  v.ajaxSettings.xhr = e.ActiveXObject ? function() {
      return !this.isLocal && Fn() || In()
    } : Fn,
    function(e) {
      v.extend(v.support, {
        ajax: !!e,
        cors: !!e && "withCredentials" in e
      })
    }(v.ajaxSettings.xhr()), v.support.ajax && v.ajaxTransport(function(n) {
      if (!n.crossDomain || v.support.cors) {
        var r;
        return {
          send: function(i, s) {
            var o, u, a = n.xhr();
            n.username ? a.open(n.type, n.url, n.async, n.username, n.password) : a.open(n.type, n.url, n.async);
            if (n.xhrFields)
              for (u in n.xhrFields)
                a[u] = n.xhrFields[u];
            n.mimeType && a.overrideMimeType && a.overrideMimeType(n.mimeType), !n.crossDomain && !i["X-Requested-With"] && (i["X-Requested-With"] = "XMLHttpRequest");
            try {
              for (u in i)
                a.setRequestHeader(u, i[u])
            } catch (f) {}
            a.send(n.hasContent && n.data || null), r = function(e, i) {
              var u, f, l, c, h;
              try {
                if (r && (i || a.readyState === 4)) {
                  r = t, o && (a.onreadystatechange = v.noop, Bn && delete Hn[o]);
                  if (i)
                    a.readyState !== 4 && a.abort();
                  else {
                    u = a.status, l = a.getAllResponseHeaders(), c = {}, h = a.responseXML, h && h.documentElement && (c.xml = h);
                    try {
                      c.text = a.responseText
                    } catch (p) {}
                    try {
                      f = a.statusText
                    } catch (p) {
                      f = ""
                    }!u && n.isLocal && !n.crossDomain ? u = c.text ? 200 : 404 : u === 1223 && (u = 204)
                  }
                }
              } catch (d) {
                i || s(-1, d)
              }
              c && s(u, f, c, l)
            }, n.async ? a.readyState === 4 ? setTimeout(r, 0) : (o = ++jn, Bn && (Hn || (Hn = {}, v(e).unload(Bn)), Hn[o] = r), a.onreadystatechange = r) : r()
          },
          abort: function() {
            r && r(0, 1)
          }
        }
      }
    });
  var qn, Rn, Un = /^(?:toggle|show|hide)$/,
    zn = new RegExp("^(?:([-+])=|)(" + m + ")([a-z%]*)$", "i"),
    Wn = /queueHooks$/,
    Xn = [Gn],
    Vn = {
      "*": [function(e, t) {
        var n, r, i = this.createTween(e, t),
          s = zn.exec(t),
          o = i.cur(),
          u = +o || 0,
          a = 1,
          f = 20;
        if (s) {
          n = +s[2], r = s[3] || (v.cssNumber[e] ? "" : "px");
          if (r !== "px" && u) {
            u = v.css(i.elem, e, !0) || n || 1;
            do
              a = a || ".5", u /= a, v.style(i.elem, e, u + r);
            while (a !== (a = i.cur() / o) && a !== 1 && --f)
          }
          i.unit = r, i.start = u, i.end = s[1] ? u + (s[1] + 1) * n : n
        }
        return i
      }]
    };
  v.Animation = v.extend(Kn, {
    tweener: function(e, t) {
      v.isFunction(e) ? (t = e, e = ["*"]) : e = e.split(" ");
      var n,
        r = 0,
        i = e.length;
      for (; r < i; r++) n = e[r],
        Vn[n] = Vn[n] || [],
        Vn[n].unshift(t)
    },
    prefilter: function(e, t) {
      t ? Xn.unshift(e) : Xn.push(e)
    }
  }), v.Tween = Yn, Yn.prototype = {
    constructor: Yn,
    init: function(e, t, n, r, i, s) {
      this.elem = e, this.prop = n, this.easing = i || "swing", this.options = t, this.start = this.now = this.cur(), this.end = r, this.unit = s || (v.cssNumber[n] ? "" : "px")
    },
    cur: function() {
      var e = Yn.propHooks[this.prop];
      return e && e.get ? e.get(this) : Yn.propHooks._default.get(this)
    },
    run: function(e) {
      var t, n = Yn.propHooks[this.prop];
      return this.options.duration ? this.pos = t = v.easing[this.easing](e, this.options.duration * e, 0, 1, this.options.duration) : this.pos = t = e, this.now = (this.end - this.start) * t + this.start, this.options.step && this.options.step.call(this.elem, this.now, this), n && n.set ? n.set(this) : Yn.propHooks._default.set(this), this
    }
  }, Yn.prototype.init.prototype = Yn.prototype, Yn.propHooks = {
    _default: {
      get: function(e) {
        var t;
        return e.elem[e.prop] == null || !!e.elem.style && e.elem.style[e.prop] != null ? (t = v.css(e.elem, e.prop, !1, ""), !t || t === "auto" ? 0 : t) : e.elem[e.prop]
      },
      set: function(e) {
        v.fx.step[e.prop] ? v.fx.step[e.prop](e) : e.elem.style && (e.elem.style[v.cssProps[e.prop]] != null || v.cssHooks[e.prop]) ? v.style(e.elem, e.prop, e.now + e.unit) : e.elem[e.prop] = e.now
      }
    }
  }, Yn.propHooks.scrollTop = Yn.propHooks.scrollLeft = {
    set: function(e) {
      e.elem.nodeType && e.elem.parentNode && (e.elem[e.prop] = e.now)
    }
  }, v.each(["toggle", "show", "hide"], function(e, t) {
    var n = v.fn[t];
    v.fn[t] = function(r, i, s) {
      return r == null || typeof r == "boolean" || !e && v.isFunction(r) && v.isFunction(i) ? n.apply(this, arguments) : this.animate(Zn(t, !0), r, i, s)
    }
  }), v.fn.extend({
    fadeTo: function(e, t, n, r) {
      return this.filter(Gt).css("opacity", 0).show().end().animate({
        opacity: t
      }, e, n, r)
    },
    animate: function(e, t, n, r) {
      var i = v.isEmptyObject(e),
        s = v.speed(t, n, r),
        o = function() {
          var t = Kn(this, v.extend({}, e), s);
          i && t.stop(!0)
        };
      return i || s.queue === !1 ? this.each(o) : this.queue(s.queue, o)
    },
    stop: function(e, n, r) {
      var i = function(e) {
        var t = e.stop;
        delete e.stop, t(r)
      };
      return typeof e != "string" && (r = n, n = e, e = t), n && e !== !1 && this.queue(e || "fx", []), this.each(function() {
        var t = !0,
          n = e != null && e + "queueHooks",
          s = v.timers,
          o = v._data(this);
        if (n)
          o[n] && o[n].stop && i(o[n]);
        else
          for (n in o)
            o[n] && o[n].stop && Wn.test(n) && i(o[n]);
        for (n = s.length; n--;)
          s[n].elem === this && (e == null || s[n].queue === e) && (s[n].anim.stop(r), t = !1, s.splice(n, 1));
        (t || !r) && v.dequeue(this, e)
      })
    }
  }), v.each({
    slideDown: Zn("show"),
    slideUp: Zn("hide"),
    slideToggle: Zn("toggle"),
    fadeIn: {
      opacity: "show"
    },
    fadeOut: {
      opacity: "hide"
    },
    fadeToggle: {
      opacity: "toggle"
    }
  }, function(e, t) {
    v.fn[e] = function(e, n, r) {
      return this.animate(t, e, n, r)
    }
  }), v.speed = function(e, t, n) {
    var r = e && typeof e == "object" ? v.extend({}, e) : {
      complete: n || !n && t || v.isFunction(e) && e,
      duration: e,
      easing: n && t || t && !v.isFunction(t) && t
    };
    r.duration = v.fx.off ? 0 : typeof r.duration == "number" ? r.duration : r.duration in v.fx.speeds ? v.fx.speeds[r.duration] : v.fx.speeds._default;
    if (r.queue == null || r.queue === !0)
      r.queue = "fx";
    return r.old = r.complete, r.complete = function() {
      v.isFunction(r.old) && r.old.call(this), r.queue && v.dequeue(this, r.queue)
    }, r
  }, v.easing = {
    linear: function(e) {
      return e
    },
    swing: function(e) {
      return .5 - Math.cos(e * Math.PI) / 2
    }
  }, v.timers = [], v.fx = Yn.prototype.init, v.fx.tick = function() {
    var e, n = v.timers,
      r = 0;
    qn = v.now();
    for (; r < n.length; r++)
      e = n[r], !e() && n[r] === e && n.splice(r--, 1);
    n.length || v.fx.stop(), qn = t
  }, v.fx.timer = function(e) {
    e() && v.timers.push(e) && !Rn && (Rn = setInterval(v.fx.tick, v.fx.interval))
  }, v.fx.interval = 13, v.fx.stop = function() {
    clearInterval(Rn), Rn = null
  }, v.fx.speeds = {
    slow: 600,
    fast: 200,
    _default: 400
  }, v.fx.step = {}, v.expr && v.expr.filters && (v.expr.filters.animated = function(e) {
    return v.grep(v.timers, function(t) {
      return e === t.elem
    }).length
  });
  var er = /^(?:body|html)$/i;
  v.fn.offset = function(e) {
    if (arguments.length)
      return e === t ? this : this.each(function(t) {
        v.offset.setOffset(this, e, t)
      });
    var n, r, i, s, o, u, a, f = {
        top: 0,
        left: 0
      },
      l = this[0],
      c = l && l.ownerDocument;
    if (!c)
      return;
    return (r = c.body) === l ? v.offset.bodyOffset(l) : (n = c.documentElement, v.contains(n, l) ? (typeof l.getBoundingClientRect != "undefined" && (f = l.getBoundingClientRect()), i = tr(c), s = n.clientTop || r.clientTop || 0, o = n.clientLeft || r.clientLeft || 0, u = i.pageYOffset || n.scrollTop, a = i.pageXOffset || n.scrollLeft, {
      top: f.top + u - s,
      left: f.left + a - o
    }) : f)
  }, v.offset = {
    bodyOffset: function(e) {
      var t = e.offsetTop,
        n = e.offsetLeft;
      return v.support.doesNotIncludeMarginInBodyOffset && (t += parseFloat(v.css(e, "marginTop")) || 0, n += parseFloat(v.css(e, "marginLeft")) || 0), {
        top: t,
        left: n
      }
    },
    setOffset: function(e, t, n) {
      var r = v.css(e, "position");
      r === "static" && (e.style.position = "relative");
      var i = v(e),
        s = i.offset(),
        o = v.css(e, "top"),
        u = v.css(e, "left"),
        a = (r === "absolute" || r === "fixed") && v.inArray("auto", [o, u]) > -1,
        f = {},
        l = {},
        c, h;
      a ? (l = i.position(), c = l.top, h = l.left) : (c = parseFloat(o) || 0, h = parseFloat(u) || 0), v.isFunction(t) && (t = t.call(e, n, s)), t.top != null && (f.top = t.top - s.top + c), t.left != null && (f.left = t.left - s.left + h), "using" in t ? t.using.call(e, f) : i.css(f)
    }
  }, v.fn.extend({
    position: function() {
      if (!this[0])
        return;
      var e = this[0],
        t = this.offsetParent(),
        n = this.offset(),
        r = er.test(t[0].nodeName) ? {
          top: 0,
          left: 0
        } : t.offset();
      return n.top -= parseFloat(v.css(e, "marginTop")) || 0, n.left -= parseFloat(v.css(e, "marginLeft")) || 0, r.top += parseFloat(v.css(t[0], "borderTopWidth")) || 0, r.left += parseFloat(v.css(t[0], "borderLeftWidth")) || 0, {
        top: n.top - r.top,
        left: n.left - r.left
      }
    },
    offsetParent: function() {
      return this.map(function() {
        var e = this.offsetParent || i.body;
        while (e && !er.test(e.nodeName) && v.css(e, "position") === "static")
          e = e.offsetParent;
        return e || i.body
      })
    }
  }), v.each({
    scrollLeft: "pageXOffset",
    scrollTop: "pageYOffset"
  }, function(e, n) {
    var r = /Y/.test(n);
    v.fn[e] = function(i) {
      return v.access(this, function(e, i, s) {
        var o = tr(e);
        if (s === t)
          return o ? n in o ? o[n] : o.document.documentElement[i] : e[i];
        o ? o.scrollTo(r ? v(o).scrollLeft() : s, r ? s : v(o).scrollTop()) : e[i] = s
      }, e, i, arguments.length, null)
    }
  }), v.each({
    Height: "height",
    Width: "width"
  }, function(e, n) {
    v.each({
      padding: "inner" + e,
      content: n,
      "": "outer" + e
    }, function(r, i) {
      v.fn[i] = function(i, s) {
        var o = arguments.length && (r || typeof i != "boolean"),
          u = r || (i === !0 || s === !0 ? "margin" : "border");
        return v.access(this, function(n, r, i) {
          var s;
          return v.isWindow(n) ? n.document.documentElement["client" + e] : n.nodeType === 9 ? (s = n.documentElement, Math.max(n.body["scroll" + e], s["scroll" + e], n.body["offset" + e], s["offset" + e], s["client" + e])) : i === t ? v.css(n, r, i, u) : v.style(n, r, i, u)
        }, n, o ? i : t, o, null)
      }
    })
  }), e.jQuery = e.$ = v, typeof define == "function" && define.amd && define.amd.jQuery && define("jquery", [], function() {
    return v
  })(window);

(function(e) {
  function l() {
    return f == true ? false : window.DeviceOrientationEvent != undefined
  }

  function c(e) {
    x = e.gamma;
    y = e.beta;
    if (Math.abs(window.orientation) === 90) {
      var t = x;
      x = y;
      y = t
    }
    if (window.orientation < 0) {
      x = -x;
      y = -y
    }
    u = u == null ? x : u;
    a = a == null ? y : a;
    return {
      x: x - u,
      y: y - a
    }
  }

  function h(e) {
    if ((new Date).getTime() < r + n)
      return;
    r = (new Date).getTime();
    var t = s.offset() != null ? s.offset().left : 0,
      u = s.offset() != null ? s.offset().top : 0,
      a = e.pageX - t,
      h = e.pageY - u;
    if (a < 0 || a > s.width() || h < 0 || h > s.height())
      return;
    if (l()) {
      if (e.gamma == undefined) {
        f = true;
        return
      }
      values = c(e);
      a = values.x / 30;
      h = values.y / 30
    }
    var p = a / (l() == true ? o : s.width()),
      d = h / (l() == true ? o : s.height()),
      v, m;
    for (m = i.length; m--;) {
      v = i[m];
      newX = v.startX + v.inversionFactor * v.xRange * p;
      newY = v.startY + v.inversionFactor * v.yRange * d;
      if (v.background) {
        v.obj.css("background-position", newX + "px " + newY + "px")
      } else {
        v.obj.css("left", newX).css("top", newY)
      }
    }
  }
  var t = 25,
    n = 1 / t * 1e3,
    r = (new Date).getTime(),
    i = [],
    s = e(window),
    o = 1,
    u = null,
    a = null,
    f = false;
  e.fn.plaxify = function(t) {
    return this.each(function() {
      var n = -1;
      var r = {
        xRange: e(this).data("xrange") || 0,
        yRange: e(this).data("yrange") || 0,
        invert: e(this).data("invert") || false,
        background: e(this).data("background") || false
      };
      for (var s = 0; s < i.length; s++) {
        if (this === i[s].obj.get(0)) {
          n = s
        }
      }
      for (var o in t) {
        if (r[o] == 0) {
          r[o] = t[o]
        }
      }
      r.inversionFactor = r.invert ? -1 : 1;
      r.obj = e(this);
      if (r.background) {
        pos = (r.obj.css("background-position") || "0px 0px").split(/ /);
        if (pos.length != 2) {
          return
        }
        x = pos[0].match(/^((-?\d+)\s*px|0+\s*%|left)$/);
        y = pos[1].match(/^((-?\d+)\s*px|0+\s*%|top)$/);
        if (!x || !y) {
          return
        }
        r.startX = x[2] || 0;
        r.startY = y[2] || 0
      } else {
        var u = r.obj.position();
        r.obj.css({
          top: u.top,
          left: u.left,
          right: "",
          bottom: ""
        });
        r.startX = this.offsetLeft;
        r.startY = this.offsetTop
      }
      r.startX -= r.inversionFactor * Math.floor(r.xRange / 2);
      r.startY -= r.inversionFactor * Math.floor(r.yRange / 2);
      if (n >= 0) {
        i.splice(n, 1, r)
      } else {
        i.push(r)
      }
    })
  };
  e.plax = {
    enable: function(t) {
      e(document).bind("mousemove.plax", function(n) {
        if (t) {
          s = t.activityTarget || e(window)
        }
        h(n)
      });
      if (l()) {
        window.ondeviceorientation = function(e) {
          h(e)
        }
      }
    },
    disable: function(t) {
      e(document).unbind("mousemove.plax");
      window.ondeviceorientation = undefined;
      if (t && typeof t.clearLayers === "boolean" && t.clearLayers)
        i = []
    }
  };
  if (typeof ender !== "undefined") {
    e.ender(e.fn, true)
  }
})(function() {
  return typeof jQuery !== "undefined" ? jQuery : ender
}())
// Plaxify all `js-plaxify` element layers
var layers = $('.js-plaxify')
$.each(layers, function(index, layer) {
  $(layer).plaxify({
    xRange: $(layer).data('xrange') || 0,
    yRange: $(layer).data('yrange') || 0,
    invert: $(layer).data('invert') || false
  })
})
$.plax.enable()
$(document).ready(function() {
  if ($('#auth').length) {
    $.ajax({
      url: '/sessions/login_404?return_to=' + window.location.pathname,
      success: function(data) {
        if (data != ' ') {
          $('#auth').html(data).slideDown(100)
          $('#login_field').attr("placeholder", "Username or Email")
          $('#password').attr("placeholder", "Password")
        }
      }
    })
    $(document).on('keydown', function(event) {
      if (event.target === document.body && event.keyCode === 192 && !event.metaKey) {
        $('#parallax_wrapper').css('-webkit-filter', 'grayscale(25%)')
        setTimeout(function() {
          window.location = '/site/toggle_site_admin_and_employee_status'
        }, 250)
        return false;
      }
    })
  }
})